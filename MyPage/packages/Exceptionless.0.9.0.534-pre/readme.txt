-------------------------------------
		Exceptionless Readme
-------------------------------------
Exceptionless provides real-time error reporting for your apps. 
It organizes the gathered information into simple actionable data that will 
help your app become exceptionless!

Learn more at http://exceptionless.com.

-------------------------------------
		How to get an api key
-------------------------------------
The Exceptionless client requires an api key to use the Exceptionless service. 
You can get your Exceptionless api key by logging into http://exceptionless.com 
and viewing your project configuration page.

-------------------------------------
		 Windows Integration
-------------------------------------
Please add the following assembly attribute and your own Exceptionless api 
key to your project (E.G., AssemblyInfo class).

[assembly: Exceptionless.Configuration.Exceptionless("API_KEY_HERE")]

Finally, you must also call this line of code to register the Exceptionless 
error handlers.

Exceptionless.ExceptionlessClient.Current.Register();

-------------------------------------
   Manually reporting an exception
-------------------------------------
By default the Exceptionless Client will report all unhandled exceptions.
You can also manually send an exception by calling the following method.

ExceptionlessClient.Submit(exception)

-------------------------------------
	  Documentation and Support
-------------------------------------
Please visit http://exceptionless.com for documentation and support.