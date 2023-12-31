CREATE TABLE "Agreement" (
	"ID"	INTEGER NOT NULL,
	"IDUser"	INTEGER NOT NULL DEFAULT 1,
	"IDClient"	INTEGER NOT NULL,
	"StartDate"	TEXT NOT NULL,
	"EndDate"	TEXT NOT NULL,
	"Amount"	REAL NOT NULL,
	"Attachment"	BLOB,
	"Active"	INTEGER NOT NULL,
	"Percent"	INTEGER NOT NULL,
	"IinstallmentCount"	INTEGER NOT NULL,
	"Installment"	REAL NOT NULL,
	"DayOfPement"	INTEGER NOT NULL,
	FOREIGN KEY("IDUser") REFERENCES "User"("ID"),
	FOREIGN KEY("IDClient") REFERENCES "Client"("ID"),
	PRIMARY KEY("ID")
)