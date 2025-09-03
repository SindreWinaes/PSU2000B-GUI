using System.Threading;

namespace PSU2000B_GUI.Services;
using System.IO.Ports;


public interface IPortDiscovery
{
    
    // List all available serial ports in the ssystem
    IEnumerable<string> GetPorts();
    
    // Tests given port 
    Task<DeviceIdentity> ProbeAsync(string portName, CancellationToken cancellationToken = default);
    
    
    
}