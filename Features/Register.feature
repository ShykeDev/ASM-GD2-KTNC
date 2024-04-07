Feature: Register

A short summary of the feature

@DataSource:../Data/Register.csv
Scenario: Kiểm thử đăng ký
	Given Truy cập trang web đăng ký: http://localhost:5027/Home/Register
	And Đăng ký với thông tin:
	| Name   | UserName   | Password   | Email   | SDT   | NgaySinh   | DiaChi   |
	| <Name> | <UserName> | <Password> | <Email> | <SDT> | <NgaySinh> | <DiaChi> |
	When Nhấn nút đăng ký
	Then Hiển thị thông báo: <result>
