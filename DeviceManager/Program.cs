using DeviceManagerLib.Domain.Model;

DeviceManager.DeviceManager deviceManager = new DeviceManager.DeviceManager();
int dataToGenerate = 5;
List<Device> devices = deviceManager.GenerateData(dataToGenerate);
deviceManager.ShowData(devices);
