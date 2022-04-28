# Module template

## Instructions

1. Check the [manifest.json](./manifest.json) file and adjust it's fields according to your module.

   You can find detailed instruction about how to adjust the manifest file on the official
   [Blish HUD Module Manifest docs](https://blishhud.com/docs/modules/overview/update-your-manifest).

2. Learn about modules from the [Blish HUD module development docs](https://blishhud.com/docs/modules/overview/anatomy).

3. Please read the [Module Citizen Guide](https://blishhud.com/docs/modules/module-citizen/overview) before you
   start developing your module and never forget, you're not the only module running on a Blish HUD users PC.

4. Check out the `MyModuleModule.cs` file. You can find a short explanation of each method your module has. Please
   remove any override method you don't plan to use in your module before publishing it.

## Debugging your module

You can debug the module by launching the Blish HUD executable with the following additional program
arguments:

```bash
--debug --module "<path to your module project folder>\bin\x64\Debug\<your module bhm file in the project output dir>.bhm"
```

Detailed instructions can be found at [Blish HUD module debugging docs](https://blishhud.com/docs/modules/overview/debugging).
