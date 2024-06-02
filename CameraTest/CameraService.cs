namespace CameraTest;

internal partial class CameraService : ICameraService
{
    public async Task<bool> CheckCameraPermissionAsync()
    {
        var status = await Permissions.CheckStatusAsync<Permissions.Camera>();

        if (status != PermissionStatus.Granted)
        {
            status = await Permissions.RequestAsync<Permissions.Camera>();
        }

        return status == PermissionStatus.Granted;
    }
}
