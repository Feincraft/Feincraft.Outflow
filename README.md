# About
**Feincraft Outflow** is an AddIn for **Microsoft Outlook** that allows processing email messages using a **Power Automate** flow.

![Outflow in action](https://github.com/Feincraft/Feincraft.Outflow/blob/master/Outflow%20O60.gif?raw=true)

Out of the box, Outflow comes with a flow that can summarize long emails into 4 sentences using Azure Language Services. However it is possible to configure Outflow to process emails using any other flow, as long as it is built in a compatible way (read "Extend Outflow" for more information).


Original announcement: https://www.linkedin.com/feed/update/urn:li:activity:6919856066583252992/


# How to Install
## Requirements
- Azure Account
- Premium Power Automate License
- Office 365 license 

## Azure Setup (Optional)
Create a Language Service from Azure Portal 

![](https://github.com/Feincraft/Feincraft.Outflow/blob/master/Readme/AzureCreate.png?raw=true)

Take note of the endpoint and API key

![](https://github.com/Feincraft/Feincraft.Outflow/blob/master/Readme/GetCredentials.png?raw=true)

This is required if you want to use the text summary flow with Outflow.

## Import flow (Optional)
Import the flow (SummarizeEmails.zip) from the release package or download it from this repository.  

![Flow](https://github.com/Feincraft/Feincraft.Outflow/blob/master/Readme/firefox_rK5Q9eLIJU.png?raw=true)

Enter the endpoint URL and API key from Azure into both HTTP actions 

![FlowEdit](https://github.com/Feincraft/Feincraft.Outflow/blob/master/Readme/FlowEdit.png?raw=true)

![FlowEdit](https://github.com/Feincraft/Feincraft.Outflow/blob/master/Readme/GetJob.png?raw=true)

Save the flow and copy its URL

![Get Flow URL](https://github.com/Feincraft/Feincraft.Outflow/blob/master/Readme/GetUrl.png?raw=true)

This is required if you want to use the text summary flow with Outflow.

## Setup AddIn
- Downlaod and extract the package 
- Run "setup.exe" 
- Restart Outlook

## Configure AddIn
Open Outflow, click on Settings and paste the flow URL

![Configure Outflow](https://github.com/Feincraft/Feincraft.Outflow/blob/master/Readme/ConfigOutflow.gif?raw=true)

# Extend Outflow
If you want to build your own flow to processes emails, you can.
All you need to do is create an Instant Flow that is triggered by an HTTP endpoint and has an HTTP Response action in the end. Whatever the response sends, will be shown in the AddIn.
The request JSON schema of the flow should be set as follows:
```json
{
    "type": "object",
    "properties": {
        "message": {
            "type": "string"
        }
    }
}
```
Alternatively you can just modify the flow provided.

**Note:** Currently Outflow will only display plain text. Future version will add the ability to render HTML as well.

![Logo](https://github.com/Feincraft/Feincraft.Outflow/blob/master/Readme/PaLoadingV4.gif?raw=true) 
