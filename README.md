# Project-Unofficial-OASA-Telematics-API-Client
**Αχμμμμ...** Τι είναι λεωφορείο???

**This is an unofficial client for the OASA Telematices API.**

# SOLUTION: 
It contains two projects.

A) **OASA.Telematics.Client :** This is the actual client project. Inside you will find two folders one for the models and one for the Client itself and the supported commands. A command is an object that allows a call to an endpoint. Once initialized with the right paremters you can call Execute method to make the call to the endpoint and get the response. See example below.

B) **OASA.Telematics.DemoTest:** The second project is a Demo - Test Console application. It contains a simple command to get all MasterLines, executes the command synchronously and displays the results.

# CALL EXAMPLES: 

A) **Sync:**        
>var request = new GetMasterLinesCommand(); 
>var response = request.Execute().Result; 

B) **Async:** 
>var request = new GetMasterLinesCommand(); 
>var response = await request.Execute();

Thanks **gph03n1x** for his detailed api documentation : 
https://github.com/gph03n1x/OASA-Telematics-API-Documentation

# Warning 
Before using the API for any product, please contact OASA in order to ask for permission or something.
