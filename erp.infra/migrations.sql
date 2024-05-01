CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `Products` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Price` decimal(65,30) NOT NULL DEFAULT 0.0,
    `StockQuantity` int NOT NULL DEFAULT 0,
    CONSTRAINT `PK_Products` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20240228011523_Initial', '7.0.2');

COMMIT;

START TRANSACTION;

ALTER TABLE `Products` MODIFY COLUMN `Price` DECIMAL(10,4) NOT NULL DEFAULT 0.0;

CREATE TABLE `StockMovements` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `ProductId` int NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `Amount` int NOT NULL DEFAULT 0,
    `Type` int NOT NULL,
    `Description` varchar(250) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_StockMovements` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_StockMovements_Products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `Products` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE INDEX `IX_StockMovements_ProductId` ON `StockMovements` (`ProductId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20240501160509_20240501.001', '7.0.2');

COMMIT;

