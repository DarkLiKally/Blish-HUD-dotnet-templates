using System.ComponentModel.Composition;
using Blish_HUD;
using Blish_HUD.Modules;
using Blish_HUD.Settings;
using Microsoft.Xna.Framework;

namespace Blish_HUD.ModuleTemplate;

[Export(typeof(Blish_HUD.Modules.Module))]
public class MyModuleModule : Module
{
    private static readonly Logger Log = Logger.GetLogger<MyModuleModule>();
    
    public static MyModuleModule? Instance { get; private set; }
    
    [ImportingConstructor]
    public MyModuleModule([Import("ModuleParameters")] ModuleParameters moduleParameters) 
        : base(moduleParameters)
    {
        Instance = this;
    }
    
    protected override Task LoadAsync()
    {
        Log.Info("MyModule loading.");
        
        /*
         * This method is called when your module is activated. This can happen when Blish HUD is starting, restarting
         * or the user clicks on the activate module button inside the Blish HUD module settings. 
         * Your module is also unloading and loading again when an automatic update is performed.
         * 
         * Load your assets and other data you need upon initialization of the module inside this method.
         *
         * You can load and cache textures, do web request or whatever asynchronous work is required for your
         * module to initialize and work.
         *
         * The module will be shown as loading on the module settings page as long as the returned task is
         * running.
         */
        
        return Task.CompletedTask;
    }

    protected override void OnModuleLoaded(EventArgs e)
    {
        Log.Info("MyModule loaded.");
        
        /*
         * Blish HUD will call this method once your module finished loading.
         * This means when the Task returned by the `LoadAsync` method completed and Blish HUD did some other
         * internal initialization work for your module.
         *
         * Please never forget to call `base.OnModuleLoaded(e)` at the end of this method when you override it in
         * your module.
         */

        base.OnModuleLoaded(e);
    }
    
    protected override void DefineSettings(SettingCollection settings)
    {
        Log.Info("MyModule is defining settings.");
        
        /*
         * Define the settings you would like to use in your module.
         * Settings are persistent between updates to both Blish HUD and your module.
         */
    }

    protected override void Initialize()
    {
        Log.Info("MyModule initialized.");
        
        /*
         * This method allows your module to initialize anything it needs before actually starting to run.
         * You can initialize global UI elements for your module in this method - like creating main windows
         * for your module.
         *
         * But you should not load data that's displayed in your UI in this callback or do any other long running
         * processing jobs.
         * 
         * Allows your module to perform any initialization it needs before starting to run.
         * Please note that Initialize is NOT asynchronous and will block Blish HUD's update
         * and render loop, so be sure to not do anything here that takes too long.
         */
    }
    
    protected override void Update(GameTime gameTime) {
        Log.Info("MyModule received an update call every frame.");
        
        /*
         * This method is called once per frame therefor it is required that the processing in this call is kept
         * at the absolute minimum that's possible.
         * Blish HUD will only start the rendering of elements when all update calls in all modules are finished.
         *
         * Other module's update calls further down the module list are blocked until your module's update call
         * is finished. Be nice to other module developers and more important the users of Blish HUD to maintain
         * a responsive UI and allow for a good user experience.
         *
         * You should also use the passed in `gameTime` argument to delay, debounce or throttle some of your
         * processing and not execute it every single frame.
         *
         * Things you normally would do in the update loop are for example updating UI elements, playing audio,
         * checking conditions, calculating changes, etc.
         */
    }
    
    protected override void Unload() {
        Instance = null;
        
        /*
         * Unload is called when your module needs to be unloaded. This is done when Blish HUD is being restarted or
         * shutting down. Also when the user clicks the deactivate module button inside the Blish HUD module settings.
         * Your module is also unloading and loading again when an automatic update is performed.
         *
         * You should use this callback for cleaning up any loaded resources, remove all static references to any
         * component or service, remove all your created event handlers or dispose your UI components.
         * This is a critical point to avoid memory leaks and other unintended behavior.
         *
         * It's important to free any unmanaged memory that's related to your module and not needed anymore and also
         * allow the .NET garbage collector to cleanup all your managed memory occupied by the module.
         */
    }
}