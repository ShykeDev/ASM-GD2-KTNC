Feature: Login

@DataSource:../Data/Login.csv
Scenario: Kiểm thử đăng nhập
	Given Truy cập trang web đăng nhập: http://localhost:5027/Home/Login
	And Nhập username: <username>
	And Nhập password: <password>
	And Bấm nút Login
	Then <result>