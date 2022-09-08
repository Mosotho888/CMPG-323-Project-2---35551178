
# How the API should be used by users
## Under authentication

-> New users need to register before they may access the API. Local users must click on the POST /api/Authenticate/register, while administrators must click on the POST /api/Authenticate/register-admin. Both users must then click the Try it out button, enter their information in the box provided, and click the Execute button to register.\
-> Click the Try it out button under POST /api/Authenticate/login, enter your login information in the field supplied, then click the Execute button and copy the provided token. \
-> After clicking the Authorize button at the top right, complete the on-screen instructions. Then click the Authorize button, after that dismiss the pop-up.\

## Under categories

-> To see all the categories that have been created, the user must first click the GET /api/Categories button, then click the Try it out button and finally the Execute button.\
-> If a user wishes to add more categories, they must click where it says POST /api/Categories, click the Try it out button, fill out the information for the category, and then click the Execute button.\
-> If a user wishes to display a certain category, they can do so by clicking where it says GET /api/categories/{id}, then hitting the button that says Try it out, then enter the categoryID that needs to be fetched in the given textbox, press the execute button, and the category will be displayed.\
-> If a user wants to update a category, they can click the PATCH /api/categories/{id} button, click the Try it out button, enter the categoryID of the category they wish to update in the provided textbox, fill out the box with the new category information, and then click the Execute button to update the category.\
-> If a user wishes to delete a category, they can click where it says DELETE /api/categories/{id}, then click the Try it out button, enter the categoryID of the desired category in the given textbox, and finally click the Execute button to delete the category.\
-> The user can select the area where it is written GET /api/categories/{id}/getAllDevicesFromSameCategory. Then click the Try it out button, enter the category ID in the given textbox, and press the Execute button to see all the devices based on the same category. \
-> The user can click where it says GET /api/categories/{id}/numberOfZones, click the Try it out button, type the category ID in the supplied textbox, and then click the Execute button to see the number of zones that belong to the same category.\

## Under devices

-> To see all the devices that have been placed, the user must first click the GET /api/Devices button, then click the Try it out button and finally the Execute button.\
-> If a user wishes to add more devices, they must click where it says POST /api/Devices, click the Try it out button, fill out the information for the device, and then click the Execute button.\
-> If a user wishes to display a certain device, they can do so by clicking where it says GET /api/Devices/{id}, then hitting the button that says Try it out, then enter the deviceID that needs to be fetched in the given textbox, press the execute button, and the device will be displayed.\
-> If a user wants to update a device, they can click the PATCH /api/Devices/{id} button, click the Try it out button, enter the deviceID of the device they wish to update in the provided textbox, fill out the box with the new device information, and then click the Execute button to update the device.\
-> If a user wishes to delete a device, they can click where it says DELETE /api/Devices/{id}, then click the Try it out button, enter the devicesID of the desired device in the given textbox, and finally click the Execute button to delete the device.\

## Under zones

-> To see all the zones that have been added, the user must first click the GET /api/Zones button, then click the Try it out button and finally the Execute button.\
-> If a user wishes to add more zones, they must click where it says POST /api/Zones, click the Try it out button, fill out the information for the zone, and then click the Execute button.\
-> If a user wishes to display a certain zone, they can do so by clicking where it says GET /api/Zones/{id}, then hitting the button that says Try it out, then enter the ZoneID that needs to be fetched in the given textbox, press the execute button, and the zone will be displayed.\
-> If a user wants to update a zone, they can click the PATCH /api/Zones/{id} button, click the Try it out button, enter the zoneID of the zone they wish to update in the provided textbox, fill out the box with the new zone information, and then click the Execute button to update the zone.\
-> If a user wishes to delete a zone, they can click where it says DELETE /api/Zones/{id}, then click the Try it out button, enter the zoneID of the desired zone in the given textbox, and finally click the Execute button to delete the zone.\
-> The user can select the area where it is written GET /api/Zones/{id}/getAllDevicesFromSameZone. Then click the Try it out button, enter the zoneID in the given textbox, and press the Execute button to see all the devices based on the same zone.\

# Reference
