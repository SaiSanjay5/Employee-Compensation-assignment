
-- Stored Procedure: Filter Employees
CREATE PROCEDURE FilterEmployees
    @Role VARCHAR(100) = NULL,
    @Location VARCHAR(100) = NULL,
    @IncludeInactive BIT = 0
AS
BEGIN
    SELECT e.name, r.role_name, l.location_name, e.current_comp_inr, e.yoe_range, 
           CASE WHEN e.is_active = 1 THEN 'Active' ELSE 'Inactive' END AS status
    FROM Employee e
    JOIN Role r ON e.role_id = r.role_id
    JOIN Location l ON e.location_id = l.location_id
    WHERE (@Role IS NULL OR r.role_name = @Role)
      AND (@Location IS NULL OR l.location_name = @Location)
      AND (@IncludeInactive = 1 OR e.is_active = 1);
END;

-- Stored Procedure: Calculate Average Compensation by Location
CREATE PROCEDURE CalculateAverageCompensation
    @Role VARCHAR(100)
AS
BEGIN
    SELECT l.location_name, 
           AVG(e.current_comp_inr) AS avg_comp_by_location
    FROM Employee e
    JOIN Role r ON e.role_id = r.role_id
    JOIN Location l ON e.location_id = l.location_id
    WHERE r.role_name = @Role
    GROUP BY l.location_name;
END;

-- Stored Procedure: Count Employees by Experience
CREATE PROCEDURE GroupByExperience
AS
BEGIN
    SELECT yoe_range, COUNT(*) AS employee_count
    FROM Employee
    GROUP BY yoe_range;
END;

-- Stored Procedure: Apply Global Increment
CREATE PROCEDURE SimulateGlobalIncrement
    @IncrementPercent FLOAT
AS
BEGIN
    SELECT name, current_comp_inr,
           current_comp_inr * (1 + @IncrementPercent / 100.0) AS revised_comp
    FROM Employee
    WHERE is_active = 1;
END;
