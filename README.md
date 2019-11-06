# VisionR

A moderation tool to show the power of Vision by Microsoft

## How to deploy it

### Angular Part on Azure

To deploy the Angular Part on Azure, you will need to create a Web App. After this, you can use ,inside Visual Studio Code, the Azure Tool extension.
Inside of it, you will find your web app and right click on it. You will find there a deploy button. To deploy, you will need to use the terminal and
write 'ng build --prod' to build the angular app in the dist foler. After this, you can click on deploy and find the folder dist to deploy your app.

### Backend Part on Azure

To deploy the backend part on Azure, you will need a Web app with SQL. This part is just an API to store the data from the angular part.
So, when you launch the project inside Visual Studio, you will go inside the appsettings.json to update the database link. You will need to put yours from
Azure. After it, you will need to make inside the terminal a command-line: "update-database". Afterthis, you can take back your publish profile from the
web App on Azure and deploy the backend by a right click on the project and deploy.

## How to use it

To use the tool, you will need to create a Computer Vision Ressource on Azure and keep your endpoint and your key. You will need your backend endpoint too.
You will need to choose the category you want to try.
After this, you can put links of pictures inside and see the service working.
