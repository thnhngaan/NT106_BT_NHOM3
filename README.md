# 🧩 BÀI TẬP NHÓM - LẬP TRÌNH MẠNG (NT106.Q12)

## 👥 Thành viên nhóm
| MSSV | Họ và tên | Vai trò |
|------|------------|----------|
| 24521137 | Trương Thị Thanh Ngân | Nhóm trưởng |
| 2452093  | Nguyễn Hiểu Lam | Thành viên |
| 24521144 | Nguyễn Hữu Nghĩa | Thành viên |
| 24520982 | Lê Văn Lộc | Thành viên |
| 24521013 | Tạ Đức Long | Thành viên |

---

📄 **Giới thiệu**

Đây là *repository* chứa **bài tập tuần 3 (Đăng ký và Đăng nhập)**.  
Vì bài này khá ngắn nên tụi em quyết định làm trước 2 thành viên và tuần sau sẽ là 3 thành viên còn lại.  
Vì là lần đầu làm việc trên Git cũng như teamwork gửi code nên còn nhiều thiếu sót.  
Tụi em sẽ cố gắng cải thiện hơn ở những dự án sau để phân bố các file khoa học nhất. 

---

## 🎯 1. Mục đích

Chức năng **Đăng ký** và **Đăng nhập người dùng** cho phép người dùng:
- Tạo tài khoản cá nhân.  
- Lưu thông tin vào cơ sở dữ liệu **SQL Server**.  
- Sử dụng tài khoản đó để truy cập hệ thống.

---

## 📝 2. Chức năng Đăng ký (Register)

**Mô tả:**
- Người dùng điền các thông tin cần thiết (Tên đăng nhập, Mật khẩu, Họ tên, Email, Số điện thoại, …) vào form đăng ký.  
- Kiểm tra hợp lệ dữ liệu (không bỏ trống, định dạng email, v.v.).  
- Nếu hợp lệ, lưu thông tin người dùng vào bảng **Users** trong **SQL Server**.

---

## 🔐 3. Chức năng Đăng nhập (Login)

**Mô tả:**
- Người dùng nhập **Tên đăng nhập** và **Mật khẩu** để truy cập hệ thống.  
- Hệ thống kiểm tra thông tin trong **Database**:  
  - Nếu trùng khớp → Đăng nhập thành công.  
  - Nếu sai → Thông báo lỗi cho người dùng.

---





