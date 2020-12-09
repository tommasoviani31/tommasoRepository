CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;

CREATE TABLE "ActivityType" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ActivityType" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NULL,
    "IsExternal" INTEGER NOT NULL
);

CREATE TABLE "Activity" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Activity" PRIMARY KEY AUTOINCREMENT,
    "ActivityTypeId" INTEGER NOT NULL,
    "Title" TEXT NULL,
    "Start" TEXT NOT NULL,
    "End" TEXT NOT NULL,
    "State" INTEGER NOT NULL,
    CONSTRAINT "FK_Activity_ActivityType_ActivityTypeId" FOREIGN KEY ("ActivityTypeId") REFERENCES "ActivityType" ("Id") ON DELETE CASCADE
);

INSERT INTO "ActivityType" ("Id", "IsExternal", "Name")
VALUES (1, 0, 'Generico');

INSERT INTO "ActivityType" ("Id", "IsExternal", "Name")
VALUES (2, 0, 'Sport');

INSERT INTO "ActivityType" ("Id", "IsExternal", "Name")
VALUES (3, 0, 'Consulenza');

INSERT INTO "ActivityType" ("Id", "IsExternal", "Name")
VALUES (4, 0, 'Studio');

INSERT INTO "ActivityType" ("Id", "IsExternal", "Name")
VALUES (5, 0, 'Casa');

CREATE INDEX "IX_Activity_ActivityTypeId" ON "Activity" ("ActivityTypeId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20201206092347_StartDb', '5.0.0');

COMMIT;