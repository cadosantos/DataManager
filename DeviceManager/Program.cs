using DeviceManagerLib.Domain.Interfaces;
using DeviceManagerLib.Domain.Services;

IIdService idService = new IdService();
IDeviceFactory deviceFactory = new DeviceFactory(idService);

DeviceManager.DeviceManager deviceManager = new DeviceManager.DeviceManager(deviceFactory);
int dataToGenerate = 5;
List<IDevice> devices = deviceManager.GenerateData(dataToGenerate);
deviceManager.ShowData(devices);
