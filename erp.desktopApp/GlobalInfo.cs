using erp.domain.Entities;

namespace erp.desktopApp;

public static class GlobalInfo
{
    private static User? _currentUser = null;

    public static User? GetCurrentUser()
    { 
        return _currentUser;
    }

    public static void SetCurrentUser(User? user)
    {
        _currentUser = user;
    }
}
