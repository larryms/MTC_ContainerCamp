## Deploy Application to Openshift

## Task 1: Login to your environment with Openshift CLI

1. Install OpenShift CLI
    ```
    https://docs.openshift.com/enterprise/3.1/cli_reference/get_started_cli.html#installing-the-cli
    ```

2. Execute the following command to login to OpenShift environment
   ```
   oc login https://YOURDOMAIN:8443/
   EX: oc login https://myopenshift.eastus.cloudapp.azure.com:8443
   ```

## Task 2: Deploy the application 
 
 1. Either create a new project or change to an existing project with the following commands
    ```
    oc new-project <NEW PROJECT NAME>   
                or 
    oc project <EXISTING PROJECT NAME>
    ```

 2. Execute the following command to deploy MYSQL pod
    ```
    oc create -f  https://raw.githubusercontent.com/Microsoft/MTC_ContainerCamp/master/modules/openshift/openshift-mysql.yaml 
    ```

 3. Execute the following command to deploy the web app and web api
    ```
    oc create -f https://raw.githubusercontent.com/Microsoft/MTC_ContainerCamp/master/modules/openshift/openshift-readinglist.yaml 
    ```
## Task 2: Access the web application
Navigate to the project you have deployed the application to in the openshift web console. In a few seconds you will see the Pods for the Web APP and Web API in the Openshift web console. You will also see a URL from the web app on the top of the page.




