
-- Role Table
CREATE TABLE Role (
    role_id INTEGER PRIMARY KEY AUTOINCREMENT,
    role_name VARCHAR(100) UNIQUE NOT NULL
);

-- Location Table
CREATE TABLE Location (
    location_id INTEGER PRIMARY KEY AUTOINCREMENT,
    location_name VARCHAR(100) UNIQUE NOT NULL
);

-- Employee Table
CREATE TABLE Employee (
    employee_id INTEGER PRIMARY KEY AUTOINCREMENT,
    name VARCHAR(100) NOT NULL,
    role_id INTEGER,
    location_id INTEGER,
    yoe_range VARCHAR(10),
    is_active BOOLEAN,
    current_comp_inr DECIMAL(12, 2),
    last_working_day DATE,
    FOREIGN KEY (role_id) REFERENCES Role(role_id),
    FOREIGN KEY (location_id) REFERENCES Location(location_id)
);

-- EmployeeRating Table
CREATE TABLE EmployeeRating (
    rating_id INTEGER PRIMARY KEY AUTOINCREMENT,
    employee_id INTEGER,
    self_rating INTEGER CHECK (self_rating BETWEEN 1 AND 5),
    manager_rating INTEGER CHECK (manager_rating BETWEEN 1 AND 5),
    FOREIGN KEY (employee_id) REFERENCES Employee(employee_id)
);

-- IndustryCompensation Table
CREATE TABLE IndustryCompensation (
    comp_id INTEGER PRIMARY KEY AUTOINCREMENT,
    role_id INTEGER,
    location_id INTEGER,
    avg_industry_comp_inr DECIMAL(12, 2),
    FOREIGN KEY (role_id) REFERENCES Role(role_id),
    FOREIGN KEY (location_id) REFERENCES Location(location_id)
);
