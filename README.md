
# How the API should be used by users
## Under authentication

-> New users need to register before they may access the API. Local users must click on the POST /api/Authenticate/register, while administrators must click on the POST /api/Authenticate/register-admin. Both users must then click the Try it out button, enter their information in the box provided, and click the Execute button to register.\
-> Click the Try it out button under POST /api/Authenticate/login, enter your login information in the field supplied, then click the Execute button and copy the provided token. \
-> After clicking the Authorize button at the top right, complete the on-screen instructions. Then click the Authorize button, after that dismiss the pop-up.

## Under categories

-> To see all the categories that have been created, the user must first click the GET /api/Categories button, then click the Try it out button and finally the Execute button.\
-> If a user wishes to add more categories, they must click where it says POST /api/Categories, click the Try it out button, fill out the information for the category, and then click the Execute button.\
-> If a user wishes to display a certain category, they can do so by clicking where it says GET /api/categories/{id}, then hitting the button that says Try it out, then enter the categoryID that needs to be fetched in the given textbox, press the execute button, and the category will be displayed.\
-> If a user wants to update a category, they can click the PATCH /api/categories/{id} button, click the Try it out button, enter the categoryID of the category they wish to update in the provided textbox, fill out the box with the new category information, and then click the Execute button to update the category.\
-> If a user wishes to delete a category, they can click where it says DELETE /api/categories/{id}, then click the Try it out button, enter the categoryID of the desired category in the given textbox, and finally click the Execute button to delete the category.\
-> The user can select the area where it is written GET /api/categories/{id}/getAllDevicesFromSameCategory. Then click the Try it out button, enter the category ID in the given textbox, and press the Execute button to see all the devices based on the same category. \
-> The user can click where it says GET /api/categories/{id}/numberOfZones, click the Try it out button, type the category ID in the supplied textbox, and then click the Execute button to see the number of zones that belong to the same category.

## Under devices

-> To see all the devices that have been placed, the user must first click the GET /api/Devices button, then click the Try it out button and finally the Execute button.\
-> If a user wishes to add more devices, they must click where it says POST /api/Devices, click the Try it out button, fill out the information for the device, and then click the Execute button.\
-> If a user wishes to display a certain device, they can do so by clicking where it says GET /api/Devices/{id}, then hitting the button that says Try it out, then enter the deviceID that needs to be fetched in the given textbox, press the execute button, and the device will be displayed.\
-> If a user wants to update a device, they can click the PATCH /api/Devices/{id} button, click the Try it out button, enter the deviceID of the device they wish to update in the provided textbox, fill out the box with the new device information, and then click the Execute button to update the device.\
-> If a user wishes to delete a device, they can click where it says DELETE /api/Devices/{id}, then click the Try it out button, enter the devicesID of the desired device in the given textbox, and finally click the Execute button to delete the device.

## Under zones

-> To see all the zones that have been added, the user must first click the GET /api/Zones button, then click the Try it out button and finally the Execute button.\
-> If a user wishes to add more zones, they must click where it says POST /api/Zones, click the Try it out button, fill out the information for the zone, and then click the Execute button.\
-> If a user wishes to display a certain zone, they can do so by clicking where it says GET /api/Zones/{id}, then hitting the button that says Try it out, then enter the ZoneID that needs to be fetched in the given textbox, press the execute button, and the zone will be displayed.\
-> If a user wants to update a zone, they can click the PATCH /api/Zones/{id} button, click the Try it out button, enter the zoneID of the zone they wish to update in the provided textbox, fill out the box with the new zone information, and then click the Execute button to update the zone.\
-> If a user wishes to delete a zone, they can click where it says DELETE /api/Zones/{id}, then click the Try it out button, enter the zoneID of the desired zone in the given textbox, and finally click the Execute button to delete the zone.\
-> The user can select the area where it is written GET /api/Zones/{id}/getAllDevicesFromSameZone. Then click the Try it out button, enter the zoneID in the given textbox, and press the Execute button to see all the devices based on the same zone.

# Endpoints
## Authentication
Authentication Login: https://apim-project2restapi.azure-api.net/api/Authenticate/login \
Authentication register: https://apim-project2restapi.azure-api.net/api/Authenticate/register \
Authentication register-Admin: https://apim-project2restapi.azure-api.net/api/Authenticate/register-admin 

## Categories

GET all categories -> https://apim-project2restapi.azure-api.net/api/Categories \
POST category -> https://apim-project2restapi.azure-api.net/api/Categories \
GET based on categoryID -> https://apim-project2restapi.azure-api.net/api/Categories/{id} \
PATCH based on categoryID -> https://apim-project2restapi.azure-api.net/api/Categories/{id} \
DELETE based on categoryID -> https://apim-project2restapi.azure-api.net/api/Categories/{id} \
GET all devices based on same categoryID: -> https://apim-project2restapi.azure-api.net/api/Categories/{id}/ getAllDevicesFromSameCategory \
GET number of zones based on categoryID -> https://apim-project2restapi.azure-api.net/api/Categories/{id}/ number of zones 

## Devices

GET all devices -> https://apim-project2restapi.azure-api.net/api/Devices \
POST device -> https://apim-project2restapi.azure-api.net/api/Devices \
GET based on deviceID -> https://apim-project2restapi.azure-api.net/api/Devices/{id} \
PATCH based on deviceID -> https://apim-project2restapi.azure-api.net/api/Devices/{id} \
DELETE based on deviceID -> https://apim-project2restapi.azure-api.net/api/Devices/{id} 

## Zones

GET all zones -> https://apim-project2restapi.azure-api.net/api/Zones \
POST zone -> https://apim-project2restapi.azure-api.net/api/Zones \
GET based on zoneID -> https://apim-project2restapi.azure-api.net/api/Zones/{id} \
PATCH based on zoneID -> https://apim-project2restapi.azure-api.net/api/Zones/{id} \
DELETE based on zoneID -> https://apim-project2restapi.azure-api.net/api/Zones/{id} \
GET all devices based on zoneID -> https://apim-project2restapi.azure-api.net/api/Zones/{id}/ getAllDevicesFromSameZone

# API Manager Endpoints
![Screenshot 2022-09-12 at 15-20-10 Microsoft Azure](https://user-images.githubusercontent.com/80751804/189667893-8e1348bd-1ca9-4ac2-8804-25b13edb8724.png) \
![Screenshot 2022-09-12 at 15-23-13 Microsoft Azure](https://user-images.githubusercontent.com/80751804/189678613-9bf8758c-a518-4375-9760-88807dc641b5.png) \
![Screenshot 2022-09-12 at 15-23-32 Microsoft Azure](https://user-images.githubusercontent.com/80751804/189678678-374aefb5-172c-4c83-a70d-e66bb6a5f410.png) \
![Screenshot 2022-09-12 at 15-24-47 Microsoft Azure](https://user-images.githubusercontent.com/80751804/189678729-0d62575d-a441-46d1-8f47-fb2cc2083d24.png)

# Reference

-> c# Corner (2021). WebApi: WebApi Patch Update Using FromBody Parameter in WebApi Using MVC4 Template. [online] www.c-sharpcorner.com. Available at: https://www.c-sharpcorner.com/UploadFile/97fc7a/webapi-webapi-patch-update-using-frombody-parameter-in-web/ [Accessed 8 Sep. 2022]. \
-> coding fusion (2021). How to Join Tables and Return Result into View Using Asp .net Mvc (tutorial). [online] www.codingfusion.com. Available at: http://www.codingfusion.com/Post/How-to-Join-tables-and-return-result-into-view-usi [Accessed 8 Sep. 2022]. \
-> Dave (2020). ASP.NET Core MVC API: How to Do a Partial Update Using HTTP PATCH. [online] Round the Code. Available at: https://www.roundthecode.com/dotnet/asp-net-core-web-api/asp-net-core-api-how-to-perform-partial-update-using-http-patch [Accessed 8 Sep. 2022].\
-> Grepper (2020). More than One DbContext Was found. Specify Which One to use. Use the ‘-Context’ Parameter for PowerShell Commands and the ‘--context’ Parameter for Dotnet commands. Code Example. [online] Codegrepper.com. Available at: https://www.codegrepper.com/code-examples/shell/More+than+one+DbContext+was+found.+Specify+which+one+to+use.+Use+the+%27-Context%27+parameter+for+PowerShell+commands+and+the+%27--context%27+parameter+for+dotnet+commands. [Accessed 8 Sep. 2022].\
-> Microsoft (2017). How to Return Record Count with Web Api. [online] social.msdn.microsoft.com. Available at: https://social.msdn.microsoft.com/Forums/en-US/816cb02d-a713-42ac-9c6e-665c6708abd9/how-to-return-record-count-with-web-api?forum=aspwebapi [Accessed 8 Sep. 2022].\
-> Oracle (2020). REST API for Oracle Service Cloud. [online] Oracle Help Center. Available at: https://docs.oracle.com/en/cloud/saas/service/18c/cxsvc/c_osvc_patch.html [Accessed 8 Sep. 2022].\
-> Rick-Anderson (2022). JsonPatch in ASP.NET Core Web API. [online] docs.microsoft.com. Available at: https://docs.microsoft.com/en-us/aspnet/core/web-api/jsonpatch?view=aspnetcore-6.0 [Accessed 8 Sep. 2022].\
-> Stackoverflow (2014a). C# - How to Initialize var? [online] Stack Overflow. Available at: https://stackoverflow.com/questions/2904689/how-to-initialize-var [Accessed 8 Sep. 2022]. \
-> Stackoverflow (2014b). Github - New Lines inside Paragraph in README.md. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/24575680/new-lines-inside-paragraph-in-readme-md [Accessed 8 Sep. 2022].\
-> Stackoverflow (2020a). .net - EF Core add-migration Build Failed. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/44785540/ef-core-add-migration-build-failed [Accessed 8 Sep. 2022].\
-> Stackoverflow (2020b). C# - Error CS0029 Cannot Implicitly Convert Type ‘Microsoft.AspNetCore.Mvc.ActionResult’ to ‘System.Collections.Generic.List’. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/55083231/error-cs0029cannot-implicitly-convert-type-microsoft-aspnetcore-mvc-actionresu [Accessed 8 Sep. 2022].\
-> stackoverflow (2018). C# - Retrieving Data from Multiple Tables through Get() Method in Web API. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/51517258/retrieving-data-from-multiple-tables-through-get-method-in-web-api [Accessed 8 Sep. 2022].\
-> stackoverflow (2019). How Do I Access Columns from Joined Tables Using Linq, C# in asp.net MVC. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/55524291/how-do-i-access-columns-from-joined-tables-using-linq-c-sharp-in-asp-net-mvc [Accessed 8 Sep. 2022].\
TekTutorialsHub (2016). Join Query in Entity Framework. [online] TekTutorialsHub. Available at: https://www.tektutorialshub.com/entity-framework/join-query-entity-framework/#using-join [Accessed 8 Sep. 2022].
