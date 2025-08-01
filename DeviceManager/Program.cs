using DeviceManagerLib.Domain.Interfaces;
using DeviceManagerLib.Domain.Services;

IDeviceTypeIdService deviceTypeIdService = new DeviceTypeIdService();
IDigitalDeviceGenerationIdService digitalDeviceGenerationIdService = new DigitalDeviceGenerationIdService();
IDigitalDeviceStrategiesFactory digitalDeviceStrategiesFactory = new DigitalDeviceStrategiesFactory(digitalDeviceGenerationIdService);
IDeviceFactory deviceFactory = new DeviceFactory(deviceTypeIdService, digitalDeviceStrategiesFactory);

DeviceManager.DeviceManager deviceManager = new DeviceManager.DeviceManager(deviceFactory, deviceTypeIdService);
int dataToGenerate = 5;
List<IDevice> devices = deviceManager.GenerateData(dataToGenerate);
deviceManager.ShowData(devices);
