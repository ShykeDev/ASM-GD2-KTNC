Feature: AddUser

A short summary of the feature

@tag1
Scenario: Kiểm thử thêm tài khoản
	Given Truy cập trang web đăng ký: http://localhost:5027/Home/Register
	And Đăng ký với thông tin:
	| Name   | UserName   | Password   | Email   | SDT   | NgaySinh   | DiaChi   |
	| <Name> | <UserName> | <Password> | <Email> | <SDT> | <NgaySinh> | <DiaChi> |
	When Nhấn nút Thêm
	Then Hiển thị thông báo: <result>
