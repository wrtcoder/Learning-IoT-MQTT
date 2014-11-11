Learning-IoT-MQTT
=================

Source code for the MQTT chapter of the book "Learning Internet of Things".

This chapter covers the basics of the MQTT protocol. It also shows how to use MQTT in the **actuator**, **sensor** and **controller** projects, each running on separate Raspberry Pis.

The source code contains the following projects:

|Project                          | Description|
|:------------------------------- |:---------- |
|**Actuator**                     | The actuator project. Controlls a sequence of digital outputs as well as an alarm output.|
|**Camera**                       | The camera project. Publishes an infrared camera and some control parameters.|
|**Controller**                   | The controller project. Controls the actuator based on input received from the sensor.|
|**Sensor**                       | The sensor project. Measures and logs temperature, light and movement.|
|**Clayster.Library.IoT**         | Library handling basic interoperability for the Internet of Things.|
|**Clayster.Library.RaspberryPi** | Library containing classes handling different types of devices connected to the Raspberry Pi interfaced through GPIO.|
|**Clayster**                     | Contains libraries that facilitate data persistence, event logging, communication, localization and scripting.|

Projects are developed in C# and compiled using [Xamarin](http://xamarin.com/). They are executed on Raspberry Pi using [MONO](http://www.mono-project.com/). By modifying the classes in Clayster.Library.RaspberryPi, the code can be made to run on other hardware platforms as well. This library is the only library that contains code specifically written for the Raspberry Pi.

Chapters of the book:

| Chapter | Title                         | Source Code |
| -------:|:----------------------------- |:-----------:|
|         | Preface                       | N/A |
| 1       | Preparing our IoT projects    | N/A |
| 2       | The HTTP Protocol             | [Learning-IoT-HTTP](https://github.com/Clayster/Learning-IoT-HTTP) |
| 3       | The UPnP Protocol             | [Learning-IoT-UPnP](https://github.com/Clayster/Learning-IoT-UPnP) |
| 4       | The CoAP Protocol             | [Learning-IoT-CoAP](https://github.com/Clayster/Learning-IoT-CoAP) |
| 5       | The MQTT Protocol             | [Learning-IoT-MQTT](https://github.com/Clayster/Learning-IoT-MQTT) |
| 6       | The XMPP Protocol             | [Learning-IoT-XMPP](https://github.com/Clayster/Learning-IoT-XMPP) |
| 7       | Using an IoT Service Platform | [Learning-IoT-IoTPlatform](https://github.com/Clayster/Learning-IoT-IoTPlatform) |
| 8       | Creating protocol gateways    | [Learning-IoT-Gateway](https://github.com/Clayster/Learning-IoT-Gateway) |
| 9       | Security and Interoperability | N/A |
