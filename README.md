# PowerBuilder-Sales-Example

The Sales App demonstrates PowerServer supporting key PowerBuilder constructs and programming style commonly used in many existing client/server applications. It is developed with Appeon PowerBuilder and deployed to the Cloud with Appeon [PowerServer 2022](https://www.appeon.com/products/powerserver). 

### Sample Project Structure

The project is structured as follows.

```
|—— PowerBuilder-Sales-Example Repository 
	|—— Native_PB				
	|—— Restful_PB
```

### Setting Up the Project

Download this PowerBuilder demo application, and then:

1. Open the PowerBuilder project in PowerBuilder 2022.

2. If you already had the corresponding SQL Anywhere database driver installed on the machine when you installed PowerBuilder 2022 and selected SQL Anywhere for Database Provider, you can just skip step#3 and step#4 below to run the PowerBuilder project directly. Otherwise, please follow the steps below to create the ODBC data source. 

3. Download the database file <b>pbdemo2021_for_sqlanywhere.zip</b> from[PowerBuilder-Project-Example-Database](https://github.com/Appeon/PowerBuilder-Project-Example-Database). 

4. Use the downloaded database file to create a new ODBC data source referring to the below must-configure connection settings:

   ```
   Data source name: 	PB Demo DB V2022	//Must be the same as the Data source name specified in the code.
   User ID: 		dba
   Password: 		sql
   ```

5. Run the PowerBuilder project.
