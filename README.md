using-requirejs
===============
Description: I want to list all the things that i learnt in building good size web application using requirejs, backbone and mvc
Basic Project Template:
ASP.Net MVC 5 with Visual Studio 2013
Build Sytem: TFS 2013
static contnet optimization: used ASP.NET web optimization and requirejs for javascript bundling and minifcation.

<h4>Additional softwares required:</h4>
Node (required on TFS build machine) <br/>
bower: npm install -g bower <br/>
require: npm install -g requirejs (required on TFS build machine) <br/>

<h4>Description for changes:</h4>
1. Moved all static content under root content folder.
2. Added flag "RunWithOptimization" in web.config - set to false, application loads unminified files (debug mode and backup option once in production)
3.App_start/BundleConfig.cs: I managed all standard libraries and css minifcation.ASP.Net optimization will handle this. 
4. content/utilities: Optimize.js for requirejs config and bat file which will run optimization routine for all javascript files under "content/scripts" folder.
  optimize.bat is even used in TFS 2013 build workflow as part of automated builds.
  Note: TFS 2013 didn't read path variables for globally installed requirejs as node module. so optimize.bat should explicitly reference all users path on windows. </br>
  <code>%appdata%\npm\r.js.cmd -o optimize.js</code>
5. Optimize.js as modules array can have all the different entry points for you application or different pages in your applications. requirejs will build one single file every element in this array by resolving all dependencies into single file.







