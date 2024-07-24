
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    UserName VARCHAR(150),
    Age INT,
	Gender VARCHAR(15),
	[Weight] FLOAT,
	Height FLOAT
);

CREATE TABLE Nutritions (
    NutritionID INT IDENTITY(1,1) PRIMARY KEY,
    NutritionName VARCHAR(150),
	Calories FLOAT,
	Protein FLOAT,
	Carbs FLOAT,
	Fat FLOAT
);

CREATE TABLE UserNutritions (
    UserNutritionID INT IDENTITY(1,1),
    UserID INT,
    NutritionID INT,
	Qty INT,
	UserNutritionDate DATETIME,
    PRIMARY KEY (UserNutritionID, UserID, NutritionID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (NutritionID) REFERENCES Nutritions(NutritionID)
);

CREATE TABLE Workouts (
    WorkoutID INT IDENTITY(1,1) PRIMARY KEY,
	WorkoutName VARCHAR(150),
	[Description] VARCHAR(255),
	Duration INT,
	CaloriesBurned FLOAT
);

CREATE TABLE UserWorkouts (
    UserWorkoutID INT IDENTITY(1,1),
    UserID INT,
    WorkoutID INT,
	WorkoutDuration INT,
	UserWorkoutDate DATETIME,
    PRIMARY KEY (UserWorkoutID, UserID, WorkoutID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (WorkoutID) REFERENCES Workouts(WorkoutID)
);

CREATE TABLE Progresses (
    ProgressID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT,
	ProgressDate DateTime,
	[Weight] FLOAT,
	CaloriesConsumed FLOAT,
	CaloriesBurned FLOAT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
