// Вывод содержимого заданной папки со всеми подпапками
using System;
using static System.Console;

Clear();
string path = "C:\\SoftPortable\\Putty";
CatalogInfo (path);

void CatalogInfo (string path, string indent = "") {
	DirectoryInfo catalog = new DirectoryInfo(path);

	DirectoryInfo[] catalogs = catalog.GetDirectories();
	for (int i = 0; i < catalogs.Length; i ++) {
		WriteLine($"{indent}{catalogs[i].Name}");
		CatalogInfo(catalogs[i].FullName, indent + " ");
	}
	FileInfo[] files = catalog.GetFiles();
	for (int i = 0; i < files.Length; i ++) {
		WriteLine($"{indent}{files[i].Name}");
	}	
}