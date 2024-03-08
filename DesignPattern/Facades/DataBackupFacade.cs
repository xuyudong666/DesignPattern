namespace DesignPattern.Facades;

public class DataBackupFacade
{
    private readonly SMSManager _sMSManager;
    private readonly ContactManager _sContactManager;

    public DataBackupFacade()
    {
        _sMSManager = new SMSManager();
        _sContactManager = new ContactManager();
    }

    public void Backup()
    {
        _sMSManager.Backup();
        _sContactManager.Backup();
    }
}
