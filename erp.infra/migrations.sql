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

START TRANSACTION;

ALTER TABLE `StockMovements` ADD `UpdatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00';

ALTER TABLE `Products` ADD `CreatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00';

ALTER TABLE `Products` ADD `UpdatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00';

CREATE TABLE `Users` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Username` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Password` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NOT NULL,
    CONSTRAINT `PK_Users` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE UNIQUE INDEX `IX_Users_Username` ON `Users` (`Username`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20240504220735_20240504.001', '7.0.2');

COMMIT;

START TRANSACTION;

CREATE TABLE `Customers` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `FirstName` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `LastName` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Email` varchar(200) CHARACTER SET utf8mb4 NOT NULL,
    `PhoneNumber` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
    `DateOfBirth` datetime(6) NOT NULL,
    `Address` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `City` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `State` varchar(2) CHARACTER SET utf8mb4 NOT NULL,
    `PostalCode` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
    `Country` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NOT NULL,
    CONSTRAINT `PK_Customers` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20240519225022_Customer', '7.0.2');

COMMIT;

START TRANSACTION;

CREATE TABLE `Orders` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CustomerId` int NOT NULL,
    `OrderDate` datetime(6) NOT NULL,
    `GlobalDiscount` decimal(18,2) NOT NULL,
    `ShippingCost` decimal(18,2) NOT NULL,
    `AdditionalExpenses` decimal(18,2) NOT NULL,
    `Status` int NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NOT NULL,
    CONSTRAINT `PK_Orders` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Orders_Customers_CustomerId` FOREIGN KEY (`CustomerId`) REFERENCES `Customers` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `OrderItems` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `OrderId` int NOT NULL,
    `ProductId` int NOT NULL,
    `Quantity` int NOT NULL,
    `UnitPrice` decimal(18,2) NOT NULL,
    `Discount` decimal(18,2) NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NOT NULL,
    CONSTRAINT `PK_OrderItems` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_OrderItems_Orders_OrderId` FOREIGN KEY (`OrderId`) REFERENCES `Orders` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_OrderItems_Products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `Products` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE INDEX `IX_OrderItems_OrderId` ON `OrderItems` (`OrderId`);

CREATE INDEX `IX_OrderItems_ProductId` ON `OrderItems` (`ProductId`);

CREATE INDEX `IX_Orders_CustomerId` ON `Orders` (`CustomerId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20240723025532_Order', '7.0.2');

COMMIT;

START TRANSACTION;

ALTER TABLE `StockMovements` ADD `Total` decimal(65,30) NOT NULL DEFAULT 0.0;

ALTER TABLE `StockMovements` ADD `UnitValue` decimal(65,30) NOT NULL DEFAULT 0.0;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250203004430_StockValue', '7.0.2');

COMMIT;

