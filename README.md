# Trần Đình Duy - 24810320299
# I. PHẦN LÝ THUYẾT & CÂU HỎI NGẮN 
## Câu 1: Trình bày sự khác nhau giữa Value Types (Kiểu giá trị) và Reference Types (Kiểu tham chiếu) trong C# về cơ chế lưu trữ vùng nhớ (Stack vs Heap). 
-	 Value Types lưu dữ liệu trực tiếp ở vùng nhớ Stack, hệ thống tự động cấp phát và giải phóng ngay khi biến ra khỏi phạm vi hoạt động. Reference Types lưu địa chỉ tham chiếu ở Stack còn dữ liệu thực tế nằm ở Heap, được bộ thu gom rác (Garbage Collector) quản lý và dọn dẹp khi không còn tham chiếu nào trỏ tới. 
-	Ngoài ra, khi gán Value Type sẽ tạo bản sao dữ liệu mới độc lập, còn gán Reference Type chỉ sao chép địa chỉ nên cả hai biến sẽ cùng thao tác trên một đối tượng. 
## Câu 2: Tính năng Init-only Properties (init) trong C# 9/10 khác gì so với thuộc tính có set thông thường? Nêu trường hợp sử dụng thực tế. 
-	 Thuộc tính init chỉ cho phép gán giá trị một lần duy nhất lúc khởi tạo đối tượng thông qua Constructor hoặc Object Initializer, sau đó sẽ chuyển sang trạng thái chỉ đọc. Thuộc tính set thông thường thì có thể thay đổi giá trị bất cứ lúc nào trong quá trình chạy chương trình. 
-	Trong thực tế, init thường dùng cho các lớp DTO nhận dữ liệu từ API hoặc các thuộc tính cố định như Id người dùng, mã đơn hàng để đảm bảo an toàn dữ liệu. 
## Câu 3: Phân biệt sự khác nhau giữa phương thức virtual ở lớp cha và phương thức override ở lớp con khi triển khai tính Đa hình (Polymorphism). 
-	Phương thức virtual khai báo ở lớp cha để cho phép các lớp con có quyền ghi đè lại nội dung. Phương thức override khai báo ở lớp con để định nghĩa lại hành vi của phương thức virtual từ lớp cha. 
-	Khi thực thi, C# dựa vào kiểu thực tế của đối tượng tại thời điểm chạy để gọi đúng phương thức override tương ứng, giúp thể hiện tính đa hình. 
## Câu 4: Tại sao một thành phần được khai báo là static trong Lớp (Class) lại không thể truy xuất thông qua một thể hiện (Object Instance) được tạo bằng toán tử new? 
-	Thành phần static thuộc về bản thân Lớp chứ không thuộc về đối tượng cụ thể nào được tạo ra từ new. Nó được cấp phát bộ nhớ một lần duy nhất và dùng chung cho toàn bộ lớp. 
-	Trình biên dịch C# chặn truy xuất static qua đối tượng để tránh việc hiểu nhầm thành phần này là dữ liệu riêng của từng đối tượng, bắt buộc người dùng phải gọi qua tên Lớp. 

