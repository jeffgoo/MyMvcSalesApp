# MyMvcSalesApp
Complete Working Solution from Julie Lerman's Entity Framework in the Enterprise Class

To get this project running and tests passing just connect to your (localdb)\MSSQLLocalDB using your windows credentials and attach the included db's: GeekStuffSales.mdf and GeekStuffSalesTester.mdf.  Then compile and run tests and all should be well.  I used VS2017 Pro. and Resharper to fix up the final project (8-entity-framework-enterprise-m8-exercise-files) from the class.  I had trouble getting migrations to work as described in the course.  I had to unload all other projects with dbcontexts and run each migration one by one.  I also had to fix up the dependent nuget assemblies, often pulling down the latest packages to fix things up.  Anyways, to save others from this housekeeping I've pushed this to github.






