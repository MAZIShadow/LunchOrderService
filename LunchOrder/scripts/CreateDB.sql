CREATE TABLE "main"."MEAL_GROUPS" (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	"NAME" VARCHAR(100) NOT NULL UNIQUE,
	"FK_MEAL_GROUP" INTEGER,
	FOREIGN KEY(FK_MEAL_GROUP) REFERENCES MEAL_GROUPS(ID)
);
 
CREATE TABLE "main"."MEALS" (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	"NAME" VARCHAR(250) NOT NULL UNIQUE,
	"PRICE" DOUBLE NOT NULL,
	"FK_MEAL_GROUP"	INTEGER NOT NULL,
	FOREIGN KEY(FK_MEAL_GROUP) REFERENCES MEAL_GROUPS(ID)
);

CREATE TABLE "main"."ORDERS" (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	"ORDER_DATE" DATETIME NOT NULL,
	"DELIVERY_EMAIL" VARCHAR(100) NOT NULL,
	"PRICE" DOUBLE NOT NULL,
	"COMMENT" VARCHAR(500)
);

CREATE TABLE "main"."ORDER_ITEMS" (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	"NAME" VARCHAR(250) NOT NULL,
	"PRICE" DOUBLE NOT NULL,
	"FK_ORDER_ITEMS" INTEGER,
	"FK_ORDERS" INTEGER NOT NULL,
	FOREIGN KEY(FK_ORDER_ITEMS) REFERENCES ORDER_ITEMS(ID),
	FOREIGN KEY(FK_ORDERS) REFERENCES ORDERS(ID)
);

INSERT INTO "main"."MEAL_GROUPS" VALUES ("1","Pizza",null);
INSERT INTO "main"."MEAL_GROUPS" VALUES ("2","Dodatki do pizzy","1");
INSERT INTO "main"."MEAL_GROUPS" VALUES ("3","Dania główne",null);
INSERT INTO "main"."MEAL_GROUPS" VALUES ("4","Dodatki do dań głównych","3");
INSERT INTO "main"."MEAL_GROUPS" VALUES ("5","Zupy",null);
INSERT INTO "main"."MEAL_GROUPS" VALUES ("6","Napoje",null);

INSERT INTO "main"."MEALS" VALUES ("1","Margheritta","20","1");
INSERT INTO "main"."MEALS" VALUES ("2","Vegetariana","22","1");
INSERT INTO "main"."MEALS" VALUES ("3","Tosca","25","1");
INSERT INTO "main"."MEALS" VALUES ("4","Venecia","22","1");
INSERT INTO "main"."MEALS" VALUES ("5","Podwójny ser","2","2");
INSERT INTO "main"."MEALS" VALUES ("6","Salami","2","2");
INSERT INTO "main"."MEALS" VALUES ("7","Szynka","2","2");
INSERT INTO "main"."MEALS" VALUES ("8","Pieczarki","2","2");
INSERT INTO "main"."MEALS" VALUES ("9","Schabowy z frytkami/ryżem/ziemniakami","30","3");
INSERT INTO "main"."MEALS" VALUES ("10","Ryba z frytkami","28","3");
INSERT INTO "main"."MEALS" VALUES ("11","Placek po węgiersku","27","3");
INSERT INTO "main"."MEALS" VALUES ("12","Bar sałatkowy","5","4");
INSERT INTO "main"."MEALS" VALUES ("13","Zestaw sosów","6","4");
INSERT INTO "main"."MEALS" VALUES ("14","Pomidorowa","12","5");
INSERT INTO "main"."MEALS" VALUES ("15","Rosół","10","5");
INSERT INTO "main"."MEALS" VALUES ("16","Kawa","5","6");
INSERT INTO "main"."MEALS" VALUES ("17","Herbata","5","6");
INSERT INTO "main"."MEALS" VALUES ("18","Cola","5","6");