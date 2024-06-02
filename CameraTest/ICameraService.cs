using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraTest;

public interface ICameraService
{
    event EventHandler<byte[]>? FrameCaptured;

    void InitializeCamera();
    void StartCamera();
    void StopCamera();

    Task<bool> CheckCameraPermissionAsync();
}
