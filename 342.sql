create procedure spUpdateEmployeeSalary
(
@id int ,
@Month varchar(255),
@Salary int,
@EmpId int
)
as 
begin
update Salary 
set EmployeeSalary=@Salary where SalaryId =@id and month=@Month and EmpolyeeId=@EmpId 
select * from employee_payroll e inner join Salary s on e.EmployeeId=s.EmloyeeId where SalaryId=@id
end