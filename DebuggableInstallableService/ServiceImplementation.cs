using DebuggableInstallableService.Framework;
using System.ServiceProcess;

namespace $safeprojectname$
{
    /// <summary>
	/// The actual implementation of the windows service goes here...
	/// </summary>
	[WindowsService("$safeprojectname$",
        DisplayName = "$safeprojectname$",
        Description = "The description of the $safeprojectname$ service.",
        EventLogSource = "$safeprojectname$",
        StartMode = ServiceStartMode.Automatic)]
    public class ServiceImplementation : IWindowsService
    {

        /// <summary>
        /// This method is called when the service gets a request to start.
        /// </summary>
        /// <param name="args">Any command line arguments</param>
        public void OnStart(string[] args)
        {
            ConsoleHarness.WriteToConsole(System.ConsoleColor.Green, "OnStart({0})", args);
        }

        /// <summary>
        /// This method is called when the service gets a request to stop.
        /// </summary>
        public void OnStop()
        {
            ConsoleHarness.WriteToConsole(System.ConsoleColor.Red, "OnStop()");
        }

        /// <summary>
        /// This method is called when a service gets a request to pause,
        /// but not stop completely.
        /// </summary>
        public void OnPause()
        {
            ConsoleHarness.WriteToConsole(System.ConsoleColor.Magenta, "OnPause()");
        }

        /// <summary>
        /// This method is called when a service gets a request to resume 
        /// after a pause is issued.
        /// </summary>
        public void OnContinue()
        {
            ConsoleHarness.WriteToConsole(System.ConsoleColor.Blue, "OnContinue()");
        }

        /// <summary>
        /// This method is called when the machine the service is running on
        /// is being shutdown.
        /// </summary>
        public void OnShutdown()
        {
            ConsoleHarness.WriteToConsole(System.ConsoleColor.DarkRed, "OnShutdown()");
        }

        /// <summary>
        /// This method is called when a custom command is issued to the service.
        /// </summary>
        /// <param name="command">The command identifier to execute.</param >
        public void OnCustomCommand(int command)
        {
            ConsoleHarness.WriteToConsole(System.ConsoleColor.DarkGreen, "OnCustomCommand({0})", command);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            ConsoleHarness.WriteToConsole(System.ConsoleColor.DarkMagenta, "Dispose()");
        }

    }
}
