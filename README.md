# PowerBuilder-Sales-Example

The Sales App demonstrates PowerServer supporting key PowerBuilder constructs and programming style commonly used in many existing client/server applications. It is developed with Appeon PowerBuilder and deployed to the Cloud with Appeon [PowerServer 2021](https://www.appeon.com/products/powerserver). 

### Sample Project Structure

The project is structured as follows.

```
|—— PowerBuilder-Sales-Example Repository 
	|—— Native_PB				
	|—— Restful_PB
```

### Setting Up the Project

Download this PowerBuilder demo application, and then:

1. Open the PowerBuilder project in PowerBuilder 2021.
2. Download the database file <b>pbdemo2021_for_sqlanywhere.zip</b> from [PowerBuilder-Project-Example-Database](https://github.com/Appeon/PowerBuilder-Project-Example-Database) and restore it. 
3. Configure the ODBC data source.
4. Copy the database connection string in the configured data source to replace the connection string in the original project. Note that the PWD in the connection string is masked. Please manually change it to the real password.
5. Run the PowerBuilder project.
