using DeviceManagerLib.Domain.Interfaces;
using DeviceManagerLib.Domain.Services;

IDeviceIdService deviceIdService = new DeviceIdService();
IDeviceFactory deviceFactory = new DeviceFactory(deviceIdService);

DeviceManager.DeviceManager deviceManager = new DeviceManager.DeviceManager(deviceFactory, deviceIdService);
int dataToGenerate = 5;
List<IDevice> devices = deviceManager.GenerateData(dataToGenerate);
deviceManager.ShowData(devices);
