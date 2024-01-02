
gen-controller:
	dotnet aspnet-codegenerator controller -name StudentController -m Student -dc ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite