# WordpressPostExtCore
# Getting Started
- open webapplication
- change ConnectionStrings in appsettings.json
- rebuild the solution
- copy the extensions DLL files into the Extensions folder of the main web application (this folder doesn’t exist by default, so you need to create it in the web application root or specify another location in the appsettings.json file; also you may just add direct dependencies to the main web application project instead, but it is not so interesting);
- run the main web application.
