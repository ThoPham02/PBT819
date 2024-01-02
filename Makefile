
gen-controller:
	dotnet aspnet-codegenerator controller -name PersonController -m Person -dc ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite