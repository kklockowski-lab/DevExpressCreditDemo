CREATE TABLE "User" (
	"ID"	INTEGER NOT NULL,
	"IDRole"	INTEGER NOT NULL,
	"FirstName"	TEXT NOT NULL,
	"LastName"	TEXT NOT NULL,
	"Login"	TEXT NOT NULL UNIQUE,
	"HashPass"	TEXT NOT NULL,
	FOREIGN KEY("IDRole") REFERENCES "SystemRole"("ID"),
	PRIMARY KEY("ID" AUTOINCREMENT)
)