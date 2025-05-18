
-- Sample Roles
INSERT INTO Role (role_name) VALUES
('Analyst'),
('Senior Analyst'),
('Manager'),
('Associate'),
('Senior Associate');

-- Sample Locations
INSERT INTO Location (location_name) VALUES
('Jaipur'),
('Banglore');

-- Sample Employees
INSERT INTO Employee (name, role_id, location_id, yoe_range, is_active, current_comp_inr, last_working_day) VALUES
('Aditi Khanna', 1, 1, '1-2', 1, 653874, NULL),
('Pooja Kaur', 2, 2, '2-3', 1, 798703, NULL);

-- Sample Ratings
INSERT INTO EmployeeRating (employee_id, self_rating, manager_rating) VALUES
(1, 5, 5),
(2, 5, 5);

-- Sample Industry Compensation
INSERT INTO IndustryCompensation (role_id, location_id, avg_industry_comp_inr) VALUES
(2, 1, 769500),
(1, 1, 570000);
