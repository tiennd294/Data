Page 1

Câu lạc bộ Visual Basic
.:: Nơi trao đổi về ngôn ngữ Visual Basic ::.

Bỏ qua nội dung

Nhập từ khóa tìm kiếm…
Đường dẫn nhanhTrợ giúpĐăng nhập
Trang chủDiễn đànTHẮC MẮC - TRAO ĐỔI - THẢO LUẬNVisual Basic for Application (VBA)
Trao đổi về Word VBA Mời vào đây!
Điều hành viên: tungblt

Nội quy chuyên mục

Tìm kiếm trong chủ đề này…
207 bài viết  1     …  
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 7 11/02/2012 3:44 pm

Lời nói đầu: VB6 là một ngôn ngữ dễ hiểu, dễ ứng dụng (trên Windows XP); tuy nhiên ứng dụng nhiều nhất của VB6 chính là một nhánh của nó: VBA cho bộ MS Office (kể cả phần mềm khác như AutoCad...).

Học cơ bản (VB6) nhuần nhuyễn là tốt, nhưng nếu có thêm ứng dụng trong cuộc sống (VBA) thì tuyệt vời hơn. Đây là điều thời gian gần đây tôi mới "ngộ" ra! _ vì trước đây cứ xem thường nó: ai lại học VBA cơ chứ?, cứ nhờ Office tự động ghi lại Macro là xong! Chả có gì gọi là "sản phẩm độc lập" cho riêng mình!

Ấy thế nhưng khi phải biên tập một file word chẳng hạn, bạn sẽ thấy VBA cần thiết đến độ nào. Tôi đang đọc truyện kiếm hiệp chuyển ngữ, (dân chuyên ngành gọi là vietphrase), đa số dịch từ truyện tàu, cú pháp đảo lộn khiến câu văn trúc trắc, khó hiểu. Mặc dù có các Tools của Word hổ trợ kèm tạo macro nhưng vẫn không đủ đáp ứng nhu cầu biên tập, thế nên dùng kiến thức VB6 để viết trực tiếp các macro hoạt động theo ý mình, thu lại kết quả thật đáng công lao!

Tại Việt Nam, VBA với Excel đã có GPE (Giải Pháp Excel) = Forum chuyên ngành về Excel (và VBA Excel), là một forum lớn và có uy tín (tôi cũng hay tham khảo tài liệu ở đấy); Còn VBA các mảng khác lại chưa có forum độc lập như Word, Access, AutoCad, OutLook... Nhiều thắc mắc về các mảng nầy "đành nhờ" CLBVB giải quyết trong Box VBA nầy.

Để thuận tiện cho các bạn đang có nhu cầu về VBA/Word, tôi mở chuyên đề nầy và chúng ta cùng thảo luận. Rất hoan nghênh các bạn (gái) đang hành xử tài liệu trên word (doc), text (txt) tham gia thảo luận.

---
(*) Word 2003 là vì tôi đang dùng với định dạng doc, nghe nói 2007 là docx... tuy nhiên mong VBA có thể giống nhau!
Sửa lần cuối bởi 1 vào ngày truongphu với 0 lần sửa trong tổng số.
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Macro Định dạng nghiêng (Italic) các từ tương tự trong file
Gửi bài by truongphu » Thứ 7 11/02/2012 6:05 pm

Mở hàng cho topic: Macro Định dạng nghiêng (Italic) các từ tương tự trong file


Ví dụ đoạn văn sau:
(TNO) Với phong cách thi đấu hoa mỹ và tinh tế, tiền vệ thiên tài người Brazil Socrates nghiễm nhiên là một trong những danh thủ xuất sắc nhất mọi thời đại, song người ta không thể chỉ nói về Socrates trên sân bóng. Ông đơn giản là hơn cả một cầu thủ.
Chúng ta muốn nhấn mạnh từ Socrates bằng cách in nghiêng trong toàn bài văn.
cách làm: Ta bôi đen (chọn) từ Socrates bất kỳ trong bài và chạy macro sau:

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub AllItalic()
    With Selection.Find
        .Text = Selection.Text
        .Replacement.Text = Selection.Text
        .Replacement.Font.Italic = True
        .Wrap = wdFindContinue
    End With
    Selection.Find.Execute Replace=wdReplaceAll
End Sub
GeSHi © Codebox Plus Extension


Để thuận tiện, ta đưa shortcut của macro trên lên menu. Tham khảo:
Tùy biến Menu Word và sử dụng macro
viewtopic.php?f=22&t=21526

các bạn có thể đọc thêm các bài viết về VBA/Word: vd
Các bài viết VB ứng dụng MS Word
viewtopic.php?f=30&t=4984
VBA MS Word
viewtopic.php?f=41&t=20042
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Viết hoa đầu dòng
Gửi bài by truongphu » Thứ 7 11/02/2012 8:53 pm

Trước đây tôi có viết bài Viết hoa đầu dòng giữ nguyên màu, đấy là bài khó; hơn nữa khi chạy khá chậm vì Selection phải làm việc từng ký tự thay đổi dựa trên từng câu.

Xem: Cuộc thi: VBA/Word Đề tài: Tìm và thay thế.
viewtopic.php?f=15&t=19972#p112186

-----
Nếu yêu cầu không cao, ta có thể dùng code gọn hơn và quan trọng là máy chạy nhanh hơn nhờ Selection ít thay đổi.
Code như sau:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub HoaDauCau()
Dim i&
For i = 97 To 121
    If (i = 102) Or (i = 106) Or (i = 119) Then GoTo BoQua ' f, j, w
   With Selection.Find
        .Text = Chr(13) & Chr(i)
        .Replacement.Text = Chr(13) & Chr(i - 32)
        .Wrap = wdFindContinue
    End With
    Selection.Find.Execute Replace=wdReplaceAll
BoQua
Next
End Sub
GeSHi © Codebox Plus Extension


Với code trên, bạn nhận ra ngay là viết hoa ký tự ascii không phải unicode.
Nếu có space trước ký tự đầu dòng, bạn phải đều chỉnh code trên với:
MÃ: CHỌN TẤT CẢ

        .Text = Chr(13) & " " & Chr(i)
        .Replacement.Text = Chr(13) & " " & Chr(i - 32)
Cho dù phải dùng vòng lặp, bảo đảm code trên vẫn thực hiện công việc trong vòng vài phút (file doc 25 MB)
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Chuyển nhanh đến Bookmark
Gửi bài by truongphu » Chủ nhật 12/02/2012 10:30 am

Chúc mừng sinh nhật Câu Lạc Bộ Visual Basic!

======

Có bạn nêu: Trong VBA MS Word 2003
viewtopic.php?f=41&t=20042
phần BooKMark có hàm Chuyển nhanh đến Bookmark
hỏi: ý nghĩa nó thế nào và cách dùng.

BookMark là đánh dấu đoạn văn nào đó, thông thường phục vụ cho việc làm mục lục (hay trích dẫn). Để làm việc nầy ta phải tạo HyperLink đến BookMark vừa tạo.
(Xem bài: Làm Mục lục trong MS Word (Version 2003)
viewtopic.php?f=30&t=4984&p=117953#p117953 )

Khi bạn đã có HyperLink/BookMark, thao tác dùng Hyperlink trên Word là Ctrl + Click = đòi hỏi phải dùng 2 tay: trái nhấn phím và phải click chuột, khá phiền toái.

Bạn chỉ cần dùng 1 tay click chuột: nhấn vào Hyperlink, xong nhấn vào nút có chứa macro trên, đấy là ý nghĩa của hàm.

Cách dùng Macro như sau:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub ChuyenDenBookmark()
 Selection.GoTo What=wdGoToBookmark, Name="Name"
End Sub
GeSHi © Codebox Plus Extension


Trong Sub trên, "Name" là tên của Bookmark mà bạn đã biết, vd:
Selection.GoTo What:=wdGoToBookmark, Name:="Chuong12"
với code nầy, dù dấu nháy con trỏ đặt ở đâu, khi chạy macro trên vẫn đưa tới đúng trang có bookmark, vì Name cố định đã khai báo.

Giả sử chúng ta lại không biết tên cụ thể của Bookmark mà Hyperlink hướng đến, bạn viết như sau:
Selection.GoTo What:=wdGoToBookmark, Name:=Selection.Hyperlinks.Item(1).Name
bạn chú ý code trên: Selection.Hyperlinks.Item(1).Name
nghĩa là Selection có hyperlink với tên là...
do đó khi sử dụng, buộc đầu tiên phải đưa con trỏ nhấn vào hyperlink để xác nhận Selection, sau đó mới chạy macro thì kết quả sẽ dẫn đến đúng trang.
Nếu dấu nháy con trỏ không đúng: kết quả chạy sai (=dấu nháy nằm ở hyperlink khác) hay báo lỗi! (=dấu nháy nằm ở vị trí không có hyperlink)
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Document được active cả khi UserForm Show
Gửi bài by truongphu » Thứ 2 13/02/2012 3:27 pm

Khi bạn chạy UserForm, chúng hiện ra và luôn luôn active trên nền Document. Nếu ta muốn edit trực tiếp trên Document, chỉ có cách đóng UseForm lại.
Nếu được chuyển Focus qua lại giữa Document và UserForm thì thuận tiện biết bao. Sau đây là cách thiết kế để đạt yêu cầu trên:

Cửa sổ UserForm Properties, kéo trượt xuống chọn ShowModal đổi thành False.
= là xong!

---------
UserForm Show ngay khi vừa mở Document:

Bạn đưa code sau vào ThisDocument của Project, (không phải của Normal)
MÃ: CHỌN TẤT CẢ

Private Sub Document_Open()
    UserForm1.Show
End Sub
File Doc nén đính kèm có UserForm hiện ngay khi mở Document, và cho phép chuyển đổi Focus qua lại giữa Document và UserForm. Bạn có thể tham khảo chúng (Gọi VBE: Alt + F11)
TẬP TIN ĐÍNH KÈM
Document Active when UserForm Show.rar
(6.78 KiB) Đã tải về 771 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Word: Bỏ chức năng Spelling & Grammar
Gửi bài by truongphu » Thứ 4 15/02/2012 7:59 am

Chức năng Spelling & Grammar là một công cụ tốt cho những người chuyên làm việc với Word; nhưng đối với người ít dùng Word thì lại khá khó chịu với nó. Việc tắt đi Word/Spelling & Grammar còn giảm bớt chức năng chạy ngầm (background) vốn hao tốn tài nguyên (RAM).
Thông thường người ta hay vào bảng Options, chọn thẻ Spelling & Grammar và bỏ kiểm các mục; việc nầy sẽ thấy ngay tác dụng là Spelling & Grammar hình như không biểu hiện nữa. Tuy thế, Spelling & Grammar vẫn chạy ngầm khi Word hoạt động!

Để tắt hẵn chương trình Spelling & Grammar mà theo ý riêng là không cần thiết, chúng ta phải vào Add or Remove Programs (Windows\Control Panel), vào mục cài đặt Microsoft office nhấn Change, bảng Setup hiện ra, kiểm mục Add or Remove Features và Next, bảng tiếp kiểm vào Choose advanced customization of appications, Next. Hãy bỏ mục Office Tools, và vào Office Shared Features bỏ Proofinf Tools, xong nhấn Update.

Word: Không hiện ra bảng Paste Option khi dán trong Documents.

Mặc định khi dán vào documents, Word sẽ hiện ra bảng Paste Option giúp chúng ta chọn lựa các kiểu định dạng đoạn văn vừa dán. Trong đa số trường hợp, điều nầy là không cần thiết và làm rườm rà, chướng mắt!.
Để tắt chức năng nầy, bạn vào Option, thẻ Edit, gần dưới có mục Cut and paste options, hãy bỏ kiểm ô Show Paste Option buttons
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Công cụ đảo ngược đoạn văn trong word
Gửi bài by truongphu » Thứ 6 17/02/2012 8:22 am

Tôi có viết một bài về vấn đề nầy:
viewtopic.php?f=30&t=4984#p111142

Để thuận tiện, ta có thể làm shortcut đến các macro trên, đưa lên menu
(Tùy biến Menu Word và sử dụng macro)
viewtopic.php?f=22&t=21526

Hoặc ta làm một userForm luôn luôn hiện ra bên cạnh
(Document được active cả khi UserForm Show)
posting.php?mode=reply&f=15&t=21600&sid ... a#pr118853

Các hình minh họa sau, chọn userform:
1.JPG
Trong hình được khoanh tròn là đoạn văn "ma pháp phương diện thiên phú". Để đảo thành "thiên phú phương diện ma pháp", tôi đặt con trỏ giữa từ "ma" như trên hình rồi nhấn nút '4-2'
(Cũng có thể bôi đen 6 từ trên rồi nhấn 4-2. 4-2 có nghĩa là tách 2 nhóm 4 từ đầu và 2 từ sau, lệnh chúng hoán vị)
kết quả sẽ là "thiên phú ma pháp phương diện" như hình sau:
2.JPG
Giờ cũng như đã làm trên, tiếp tục đảo 4 từ sau với nút nhấn 2-2
3.JPG
Đấy là công dụng của VBA: thao tác công việc trở nên đơn giản và nhanh chóng vô cùng!
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Macro Xóa nội dung cần tìm.
Gửi bài by truongphu » Thứ 7 18/02/2012 1:48 pm

Xem câu hỏi: viewtopic.php?f=15&p=119046#p119046
Nhóm biên tập : aaaaa
Nguồn : cccccc
nội dung word

Nhóm biên tập : bbbbbb
Nguồn : cccccc
nội dung word

vậy có cách nào xóa phần nhóm biên tập và nguồn đi được không. (chú ý: aaaaaa, bbbbbb, cccccc là nội dung thay đổi nhưng mình cũng muốn xóa luôn)
Các từ tìm kiếm là "Nhóm biên tập", "Nguồn :"; tuy nhiên nội dung kèm các từ đó lại thay đổi và cần xóa!
Như vậy ta không thể dùng Selection.Find.Text cùng Selection.Find.Replacement.Text được.
Ta chỉ có thể đưa dấu nháy chạy từng câu, chọn câu đó xem trong đó có nội dung tìm không, nếu có thì xóa cả câu.

* Giả sử đoạn văn sau "Nhóm biên tập" là trên cùng một câu, cũng như thế với "Nguồn :"
Ta chạy macro như sau:

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub XoaDoanVanTim(NoiDungTim1 As String, Optional ByVal NoiDungTim2 As String = "")
    'Ðua dâu nháy vê Ðâu document
   Selection.HomeKey unit=wdStory
Do Until Selection.Range.Bookmarks.Exists("\EndOfDoc") = True ' cho Ðê'n cuô'i document
  Selection.Move wdSentence, 1 ' move tu'`ng câu
  Selection.MoveRight wdSentence, 1, wdExtend ' chon ca câu bôi Ðen
 
   If InStr(Selection.Text, NoiDungTim1) Then Selection.Delete
   If Len(NoiDungTim2) Then
    If InStr(Selection.Text, NoiDungTim2) Then Selection.Delete
   End If
Loop ' Vòng lap
End Sub
 
Sub ChayMacroXóa()
    XoaDoanVanTim "Nhóm biên", "Ngu" & ChrW(&H1ED3) & "n"
End Sub
GeSHi © Codebox Plus Extension


=> Sub XoaDoanVanTim là macro chính, Sub ChayMacroXóa là macro gọi Sub XoaDoanVanTim ra chạy.
=> Sở dĩ tôi viết đến 2 macro vì để các bạn khác cần dùng, chỉ cần thay các đối số thích hợp ở Sub ChayMacroXóa là xong.
* đối số 1 tôi bỏ chữ "tập" vì dính unicode, đối số 2 đành phải kèm ký tự unicode
=> XoaDoanVanTim là macro chính có 2 đối số: NoiDungTim1 là bắt buộc phải có, NoiDungTim2 không có cũng được
MÃ: CHỌN TẤT CẢ

   If Len(NoiDungTim2) Then
    If InStr(Selection.Text, NoiDungTim2) Then Selection.Delete
   End If
nghĩa là nếu có NoiDungTim2 thì xóa, không có thì bỏ qua
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Delete nhiều trang
Gửi bài by truongphu » Thứ 2 27/02/2012 10:16 am

Bạn muốn xóa rất nhiều trang trong document, ví dụ xóa 300 trang đầu tiên.

Thông thường ta làm bằng tay: Nhấn chuột trái từ đầu file và kéo rê xuống, đến vị trí cuối trang 300 thì thả chuột = bôi đen chọn 300 trang đầu.
Việc kéo rê vài trang thì chòn được, nhưng kéo rê vài trăm trang thì có chút nhọc sức! Hãy dùng code sau:

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Selection.GoTo What=wdGoToPage, Which=wdGoToNext, Name="301"
Selection.HomeKey Unit=wdStory, Extend=wdExtend
Selection.Delete
GeSHi © Codebox Plus Extension


Dòng 1: con trỏ di chuyển đầu trang 300 + 1
Dòng 2: Bôi đen từ đầu đến cuối trang 300
Dòng 3: Xóa

Đơn giản chứ nhỉ? :-j
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Xóa trang đang đọc
Gửi bài by truongphu » Thứ 2 27/02/2012 1:52 pm

current page là trang mà selection (dấu nháy con trỏ) đang hiện diện
MÃ: CHỌN TẤT CẢ

    Selection.GoTo What:=wdGoToBookmark, Name:="\page"
    Selection.Delete
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Cắt nửa file doc khi file có dung lượng rất lớn
Gửi bài by truongphu » Thứ 6 09/03/2012 8:40 am

Thông thường để Cut hay Copy một đoạn văn, ta phải bôi đen đoạn văn ấy. Với file nhỏ vài trăm ký thì không yêu cầu gì: ta cứ việc nhấn nút trái chuột và kéo rê cho đến khi đạt yêu cầu. Tuy nhiên khi file dung lượng rất lớn từ chục MB trở lên thì việc chọn bôi đen như thế rõ ràng là không khả thi!
Thế nhưng bạn có thấy, dù file lớn đến đâu, nếu ta nhấn nút Select All (Ctrl A) thì toàn bộ file đều được chọn ngay tức khắc! Điều nầy có nghĩa là có cách chọn nhanh.

1- Xác định file word (doc) có bao nhiêu trang?
-> Công tác nầy dễ, không cần code. Bạn chỉ việc mở file và ngồi đợi (không thao tác trên file đang mở). Sở dĩ ngồi đợi vì công tác đọc file (Repaginate) dung lượng lớn khá chậm, chúng hoạt động nền (background) nên ta không làm việc gì để nhường cho chúng. (file nhỏ thì tức thời, file 20 MB chừng nửa phút).
Trên thanh Status (dưới cùng), bạn sẽ thấy: Page xxx là trang hiện tại (current), cách đó là tỉ trang hiện tại/Tổng số trang xxx/yyy. yyy là tổng số trang của file.

-> Nhanh hơn, ngay khi bạn mở file doc, vào menu File, xuống Properties, chọn bảng Statistics, đương nhiên cũng ngồi đợi một lát, sẽ hiện lên các thông số của file.

-> Với VBA, bạn có thể chạy1 trong 2 cách sau:
MÃ: CHỌN TẤT CẢ

Sub TongSoTrang1()
ActiveDocument.Repaginate
MsgBox ActiveDocument.BuiltInDocumentProperties(wdPropertyPages)
End Sub
MÃ: CHỌN TẤT CẢ

Sub TongSoTrang2()
ActiveDocument.Repaginate
MsgBox ActiveDocument.BuiltInDocumentProperties("Number of Pages")
End Sub
Hai cách trên đề giống nhau: yêu cầu word đọc file sau đó thông báo. Chúng chỉ khác nhau hằng số sử dụng.

2- Chọn điểm giữa file
Ta biết số yyy là tổng số trang, nửa file sẽ là yyy/2
vd yyy = 6000, nửa file là 3000
Bạn chạy code sau:
MÃ: CHỌN TẤT CẢ

Selection.GoTo What:=wdGoToPage, Which:=wdGoToAbsolute, Count:=3000
đương nhiên ta không nên cắt file "máy móc" như thế mà nên chọn đến chổ nào vừa hết chương, có nhiều khoảng trống xuống hàng.
Nghĩa là câu code trên có thể sửa lại số trang ở sau: tới thêm vài trang hay lùi lại vài trang, aaa = (yyy/2) +- bbb
MÃ: CHỌN TẤT CẢ

Selection.GoTo What:=wdGoToPage, Which:=wdGoToAbsolute, Count:=2978
Xem dấu nháy con trỏ: cũng chưa đến vị trí yêu cầu! vẫn còn cách một số dòng...
ta cho dấu nháy chạy tới tiếp vài dòng:
MÃ: CHỌN TẤT CẢ

Selection.GoTo What:=wdGoToLine, Which:=wdGoToRelative, Count:=10
nếu lùi lại thì:
MÃ: CHỌN TẤT CẢ

Selection.GoTo What:=wdGoToLine, Which:=wdGoToPrevious, Count:=8
3- Chọn nửa file:
- Chọn nửa file đầu:
MÃ: CHỌN TẤT CẢ

Selection.HomeKey Unit:=wdStory, Extend:=wdExtend
- Chọn nửa file sau:
MÃ: CHỌN TẤT CẢ

Selection.EndKey Unit:=wdStory, Extend:=wdExtend
bài viết khá dài, thực ra ta chỉ có vài dòng code (chọn nửa sau):

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Selection.GoTo What=wdGoToPage, Which=wdGoToAbsolute, Count=1694
Selection.GoTo What=wdGoToLine, Which=wdGoToRelative, Count=10
Selection.EndKey Unit=wdStory, Extend=wdExtend
GeSHi © Codebox Plus Extension


Trên cơ sở code nầy, bạn có thể cắt đoạn bất kỳ ở hai đầu khá nhanh; nếu cắt đoạn giữa hơi mất công một tí nhưng cũng nhanh.
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
cách lọc chữ trong word
Gửi bài by truongphu » Thứ 6 16/03/2012 11:48 am

Trích: Cho mình hỏi cách lọc chữ trong word bằng VB !!!
viewtopic.php?f=7&p=120480#p120474
noname_nonme đã viết:
nhưng mà làm sao để bắt được chữ ở trên vậy bạn vd đoạn code trên consider ,
nếu đoạn khác là của chữ fly , negotiate ,... . có độ dài chữ khác nhau
Toàn bộ thao tác dùng đối tượng Selection
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub FindCopyFindPaste()
 
' Ðua vê Ðâu trang
   Selection.HomeKey unit=wdStory, Extend=wdMove
' Tìm chuôi <front>
   Selection.Find.Text = "<front>"
    Selection.Find.Execute
' Tìm ra thì Ðua dâ'u nháy vê cuôi    
   Selection.Collapse Direction=wdCollapseEnd
'  Di chuyên qua phai 1 chu và bôi Ðen = chon
   Selection.MoveRight unit=wdWord, Count=1, Extend=wdExtend
   
' khai báo 1 biên String Ðê làm tên file audio    
   Dim MM$ MM = Trim(Selection.Text) & ".MP3"
'Ðua dâ'u nháy vê cuôi
   Selection.Collapse Direction=wdCollapseEnd
 
' tìm  <front_audio_filename>
   Selection.Find.Text = "<front_audio_filename>"
    Selection.Find.Execute
 
' Ðua dâ'u nháy vê cuôi
   Selection.Collapse Direction=wdCollapseEnd
' chon bên phai 8 ký tu
   Selection.MoveRight unit=wdCharacter, Count=8, Extend=wdExtend
' Dán tên file audio vào Ðó
   Selection.Text = MM
End Sub
GeSHi © Codebox Plus Extension
TẬP TIN ĐÍNH KÈM
Doc1.rar
(6.88 KiB) Đã tải về 631 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Xóa Hyperlink, Bookmark và tag
Gửi bài by truongphu » Thứ 7 21/04/2012 11:23 am

nhochoclaptrinh đã viết:
Trong MS Word mình có copy một bài viết từ Wikipedia, mọi người giúp mình cách viết code VB6 để xóa tính chất Hiperlink và xóa luôn các con số có dạng [1], [2], ....
Thanks
viewtopic.php?f=15&t=22537

Uzumaki Naruto đã hướng dẫn về xóa Hyperlink:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
    Dim oField As Field
    For Each oField In ActiveDocument.Fields
        If oField.Type = wdFieldHyperlink Then oField.Unlink
    Next
    Set oField = Nothing
GeSHi © Codebox Plus Extension


Tương tự ta xóa Bookmark:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
    Dim sBmark As Bookmark
    For Each sBmark In ActiveDocument.Bookmarks
        sBmark.Delete
    Next
    Set sBmark = Nothing
GeSHi © Codebox Plus Extension


các con số có dạng [1], [2], .. hay cả [n], [abc] ta có code xóa sau:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
    Selection.Find.ClearFormatting
    With Selection.Find
        .MatchWildcards = True
        .Text = "\[*\]"
        .Replacement.Text = ""
        .Wrap = wdFindContinue
    End With
    Selection.Find.Execute Replace=wdReplaceAll
GeSHi © Codebox Plus Extension
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Xóa các tag của source trang web
Gửi bài by truongphu » Thứ 2 23/04/2012 7:10 am

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub Delhtmltags()
    Selection.Find.ClearFormatting
    With Selection.Find
        .MatchWildcards = True
        .Text = "\<*\>"
        .Replacement.Text = ""
        .Wrap = wdFindContinue
    End With
    Selection.Find.Execute Replace=wdReplaceAll
End Sub
GeSHi © Codebox Plus Extension
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
doantrinh86
Bài viết: 1
Ngày tham gia: Chủ nhật 22/04/2012 3:14 pm
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by doantrinh86 » Thứ 3 24/04/2012 8:49 am

Mình có thắc mắc xin hỏi các bạn về hàm trong Excel.
Mình cần làm việc trong Excel với công thức chung như sau:
Mình có trước các hàng A1, A3, A4,A6,A7, A9,A10....
Mình cần thực hiện phép tính như sau:
A2=A1-A3
A5=A4 - A6
A8=A7-A9
.....
Tiếp theo các tổ hợp hàng khác đều như vậy.
Xin hỏi mọi người có ai có cách tự động hóa trong Excel giúp mình để đỡ mất thời gian hơn!
Cảm ơn các bạn!
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by truongphu » Thứ 3 24/04/2012 9:03 am

@doantrinh86:
Nếu bạn doantrinh86 gởi bài về VBA/Word thì ở đây
còn Excel, mong bạn gới bài riêng (nhấn nút chủ đề mới)

mục đích để Chủ đề nầy thuần về Word/VBA
OK? :)
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
thanhphongialy
Thành viên chính thức
Thành viên chính thức
Bài viết: 12
Ngày tham gia: Chủ nhật 29/04/2012 9:03 am
Been thanked: 3 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by thanhphongialy » Thứ 5 03/05/2012 8:08 pm

Cảm ơn anh TruongPhu đã hướng dẫn! Xin giúp đỡ!
E đã tạo 1 form, tìm và thay thế các bookmark bằng các textbox. E muốn lưu file doc này với 1 tên được lấy từ 1 textbox (txtTen) trong form, code thế nào, xin chỉ giúp!
Trong access code chạy được, chuyển qua VB phải thế nào?
MÃ: CHỌN TẤT CẢ

oApp.ActiveDocument.SaveAs Filename:=CurrentProject.Path & "\" & txtTen & ".doc"
MÃ: CHỌN TẤT CẢ

oApp.ActiveDocument.SaveAs Filename:="C:\ & txtTen & .doc"
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by truongphu » Thứ 6 04/05/2012 8:21 am

MÃ: CHỌN TẤT CẢ

oApp.ActiveDocument.SaveAs App.Path & "\" & txtTen & ".doc"
MÃ: CHỌN TẤT CẢ

oApp.ActiveDocument.SaveAs "C:\" & txtTen & ".doc"
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
thanhphongialy
Thành viên chính thức
Thành viên chính thức
Bài viết: 12
Ngày tham gia: Chủ nhật 29/04/2012 9:03 am
Been thanked: 3 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by thanhphongialy » Thứ 3 08/05/2012 11:02 am

đã làm được, đúng là 'không thầy-bó tay"
chân thành cảm ơn bác truongphu, nếu có thể, cho tôi địa chỉ, tôi gởi biếu bác ít cafe, hậu tạ! (để có gì hỏi nửa đỡ ngại, hì)
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by truongphu » Thứ 3 08/05/2012 12:20 pm

thanhphongialy đã viết:
nếu có thể, cho tôi địa chỉ, tôi gởi biếu bác ít cafe, hậu tạ!
có lý!
uống cà phê đọc code mắt sẽ sáng hơn =D>
5 Hồ Xuân Hương, Cam Đức, Cam Lâm, Khánh hòa
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
207 bài viết  1     …  
Quay về
Trang chủDiễn đànThời gian được tính theo giờ UTC+07:00 UTC+7Xoá cookie của websiteLiên hệ chúng tôi
Đã tích hợp phpBB® Forum Software © phpBB Limited

Vietnamese language pack for phpBB 3.2.x download and support.

PRIVACY_LINK | TERMS_LINK


Page 2

Câu lạc bộ Visual Basic
.:: Nơi trao đổi về ngôn ngữ Visual Basic ::.

Bỏ qua nội dung

Nhập từ khóa tìm kiếm…
Đường dẫn nhanhTrợ giúpĐăng nhập
Trang chủDiễn đànTHẮC MẮC - TRAO ĐỔI - THẢO LUẬNVisual Basic for Application (VBA)
Trao đổi về Word VBA Mời vào đây!
Điều hành viên: tungblt

Nội quy chuyên mục

Tìm kiếm trong chủ đề này…
207 bài viết    2    …  
thanhphongialy
Thành viên chính thức
Thành viên chính thức
Bài viết: 12
Ngày tham gia: Chủ nhật 29/04/2012 9:03 am
Been thanked: 3 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by thanhphongialy » Thứ 3 15/05/2012 9:51 am

Sáng nay đã gởi! Khi nào bác nhận đc, bác tíc 1 cái để tôi biết! Chúc bác sức khỏe!
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by truongphu » Chủ nhật 20/05/2012 4:03 pm

thanhphongialy đã viết:
Khi nào bác nhận đc, bác tíc 1 cái để tôi biết! Chúc bác sức khỏe!
Đã nhận quà, Cảm ơn bạn nhen :)
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
caotrung
Bài viết: 3
Ngày tham gia: Chủ nhật 20/05/2012 9:39 pm
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by caotrung » Chủ nhật 20/05/2012 9:52 pm

Chào bác truongphu! Em mới biết đến diễn đàn này, thấy bác giỏi quá, giúp ích được rất nhiều người trong khi làm việc với word. Em không rảnh về ngôn ngữ lập trình, nên chỉ tạo được các macro theo cách Record thôi, với lại cũng sưu tầm được ít code của mấy bác về dùng.
Hiện nay em đang có một vấn đề là trong một tài liệu word gồm rất nhiều câu hỏi trắc nghiệm, do sưu tầm được nên có nhiều câu bị trùng nhau. Em muốn nhờ bác viết giúp một đoạn mã để đánh dấu những câu trùng nhau, hoặc xóa luôn các câu trùng ( -1 ) đi cũng được.
Nếu được như vậy em xin hậu tạ nhiều nhiều
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by truongphu » Thứ 2 21/05/2012 8:31 am

caotrung đã viết:
tạo được các macro theo cách Record thôi, với lại cũng sưu tầm được ít code của mấy bác về dùng.
Record cũng là cách tôi học khi mới quen VBA đấy. Bạn sử dụng công cụ nầy nhiều sẽ thành thạo không thua ai!
caotrung đã viết:
word gồm rất nhiều câu hỏi trắc nghiệm, do sưu tầm được nên có nhiều câu bị trùng nhau. Em muốn nhờ bác viết giúp một đoạn mã để đánh dấu những câu trùng nhau, hoặc xóa luôn các câu trùng ( -1 ) đi cũng được.
Nếu được như vậy em xin hậu tạ nhiều nhiều
1- Câu hỏi trắc nghiệm, đáp án câu cuối rất dễ trùng, vd: "Cả 3 câu trên đều sai"; hoặc đều đúng. Bạn phải đặt điều kiện để loại trừ các trường hợp nầy.
2- a)- Thông thường ta đọc toàn bộ document vào một biến, tách từng câu vào một mảng. Dùng 2 vòng lặp xen kẻ duyệt mảng nầy để so sánh tìm các câu trùng.
b)- cách hiện đại hơn là: Tạo một kho, duyệt từng câu, xem kho có chưa?, nếu chưa thì gởi vào kho, đã có thì xóa câu.
3- "hậu tạ nhiều nhiều" nghĩa là gì thế? thích dữ a! ;;)

Code VBA (đã chạy tốt trên MS Word 2003)
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub TìmXoáCâuTrùng()
Dim KhoCâu As Object ' truongphu
Set KhoCâu = CreateObject("Scripting.Dictionary")
    Selection.HomeKey Unit=wdStory, Extend=wdMove
    Do Until Selection.Range.Bookmarks.Exists("\EndOfDoc") = True
        Selection.Move wdSentence, 1
        Selection.MoveRight wdSentence, 1, wdExtend
        If KhoCâu.Exists(Selection.Text) Then
            Selection.Delete
        Else
            KhoCâu.Add Selection.Text, ""
        End If
    Loop
End Sub
GeSHi © Codebox Plus Extension

dòng 3: tạo thư viện
4: con trỏ về đầu document
5: sẽ di chuyển đến cuối document
6: move từng câu
7: bôi đen cả câu
8: điều kiện: hỏi kho đã có câu chưa
9: có thì xóa
11: không thì lưu

hay không? quá gọn nhẹ :>
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
caotrung
Bài viết: 3
Ngày tham gia: Chủ nhật 20/05/2012 9:39 pm
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by caotrung » Thứ 3 22/05/2012 2:49 pm

Cảm ơn bác đã giúp đỡ. Em đã làm chạy thử theo đoạn mã bác viết nhưng kết quả không hoàn hảo lắm. Em chép kết quả vào đây bác xem gúp nha. Trước khi chạy đoạn câu hỏi trắc nghiệm như sau:
Câu 1: Con lắc lò xo trên mặt phẳng nghiêng góc α = 30o so với mặt phẳng ngang có điểm treo phía dưới, vật m = 300 g gắn ở đầu trên. Đẩy vật tới vị trí lò xo bị nén 3 cm rồi thả nhẹ. Cơ năng của hệ là 30 mJ và g = 10 m/s2. Biên độ dao động của hệ có giá trị.
A. 3 cm B. 1,5 cm . C. 2 cm D. 6 cm
Câu 2: Một vật nhỏ có khối lượng m = 100 g dao động điều hòa với chu kì là 2 s. Tại vị trí biên, gia tốc của vật có độ lớn là 80 cm/s2. Cho = 10. Cơ năng dao động của vật là
0,32 mJ. B. 3,2 mJ. C. 0,32 J. D. 3,2 J.
Câu 3: Một con lắc lò xo dao động điều hoà . Nếu tăng độ cứng lò xo lên 2 lần và giảm khối lượng đi hai lần thì cơ năng của vật sẽ
không đổi B. tăng bốn lần C. tăng hai lần D. giảm hai lần
Câu 4: Con lắc lò xo có độ cứng k = 90(N/m) khối lượng m = 800(g) được đặt nằm ngang. Một viên đạn khối lượng m0 = 100(g) bay với vận tốc v0 = 18(m/s), dọc theo trục lò xo, đến cắm chặt vào M. Biên độ và tần số góc dao động của con lắc là:
4(cm); 2(rad/s) B. 2(cm); 4(rad/s)
C. 4(cm); 25(rad/s) D. 20(cm); 10(rad/s)
Câu 1: Con lắc lò xo trên mặt phẳng nghiêng góc α = 30o so với mặt phẳng ngang có điểm treo phía dưới, vật m = 300 g gắn ở đầu trên. Cơ năng của hệ là 30 mJ và g = 10 m/s2.
3 cm B. 1,5 cm . C. 2 cm D. 6 cm

Có hai câu trùng nhau ở đầu và ở cuối. Sau khi chạy macro thì kết quả được:
Câu 1: Con lắc lò xo trên mặt phẳng nghiêng góc α = 30o so với mặt phẳng ngang có điểm treo phía dưới, vật m = 300 g gắn ở đầu trên. Đẩy vật tới vị trí lò xo bị nén 3 cm rồi thả nhẹ. Cơ năng của hệ là 30 mJ và g = 10 m/s2. Biên độ dao động của hệ có giá trị.
A. 3 cm B. 1,5 cm . C. 2 cm D. 6 cm
Câu 2: Một vật nhỏ có khối lượng m = 100 g dao động điều hòa với chu kì là 2 s. Tại vị trí biên, gia tốc của vật có độ lớn là 80 cm/s2. Cho = 10. Cơ năng dao động của vật là
0,32 mJ. B. 3,2 mJ. C. 0,32 J. D. 3,2 J.
Câu 3: Một con lắc lò xo dao động điều hoà . Nếu tăng độ cứng lò xo lên 2 lần và giảm khối lượng đi hai lần thì cơ năng của vật sẽ
không đổi B. tăng bốn lần C. tăng hai lần D. giảm hai lần
Câu 4: Con lắc lò xo có độ cứng k = 90(N/m) khối lượng m = 800(g) được đặt nằm ngang. Một viên đạn khối lượng m0 = 100(g) bay với vận tốc v0 = 18(m/s), dọc theo trục lò xo, đến cắm chặt vào M. Biên độ và tần số góc dao động của con lắc là:
4(cm); 2(rad/s) B. 2(cm); 4(rad/s)
C. 4(cm); 25(rad/s) D. 20(cm); 10(rad/s)
Câu 1: Con lắc lò xo trên mặt phẳng nghiêng góc α = 30o so với mặt phẳng ngang có điểm treo phía dưới, vật m = 300 g gắn ở đầu trên.
1,5 cm . 2 cm D.


Rõ ràng câu cuối đã bị xóa một phần.
Chắc là em phải tìm và xóa bằng tay thôi. Mất nhiều thời gian một chút. Em mới biết về kĩ thuật Macro, và cũng ứng dụng được một ít rồi, thấy công việc nhẹ như mây. Cảm ơn những người như bác rất nhiều.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by truongphu » Thứ 3 22/05/2012 3:13 pm

caotrung đã viết:
Chắc là em phải tìm và xóa bằng tay thôi. Mất nhiều thời gian một chút.
Thế thì còn gì là KH-KT? :D
caotrung đã viết:
Rõ ràng câu cuối đã bị xóa một phần.
Bạn dùng MS Word nhưng chưa phân biệt từ mà Word sử dụng:

* Đoạn văn: paragraph = dài, có thể có nhiều câu (kết thúc dấu chấm.), có thể có nhiều đoạn (kết thúc dấu phẩy,)
* Câu: sentence kết thúc dấu chấm.
dấu chấm và dấu phẩy phải dính sát từ ngữ trước đó.

Câu 1 trùng của bạn, đó là paragraph chứ không phải sentence.
caotrung đã viết:
Rõ ràng câu cuối đã bị xóa một phần.
Do đó, nói cho chính xác (với code) là Đoạn văn 1 đã bị xóa CÂU cuối :P

và các câu đáp án của bạn: vd
A. 3 cm B. 1,5 cm . C. 2 cm D. 6 cm
Chúng không gọi là câu mà là paragraph tuốt.

* Khắc phục: Thay các dấu chấm trong đoạn văn thành dấu phẩy hay dấu gì đó khác dấu chấm. và kết thúc câu bằng dấu chấm.
vd:
Câu 1: Con lắc lò xo trên mặt phẳng nghiêng góc α = 30o so với mặt phẳng ngang có điểm treo phía dưới, vật m = 300 g gắn ở đầu trên; Đẩy vật tới vị trí lò xo bị nén 3 cm rồi thả nhẹ, Cơ năng của hệ là 30 mJ và g = 10 m/s2, Biên độ dao động của hệ có giá trị.
A) 3 cm B) 1,5 cm C) 2 cm D) 6 cm.

như thế là chạy êm

* Hoặc thay hằng wdSentence = câu với hằng wdParagraph = đạn văn
Selection.MoveRight wdParagraph, 1, wdExtend

Trả lời nhanh, Chưa Test!
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
MS Word abc.
Gửi bài by truongphu » Thứ 5 24/05/2012 8:15 am

Kiến thức cần có khi soạn thảo văn bản. Một văn bản 'chuẩn mực' như MS Word quy định mới có thể chạy các macro 'trơn tru' được.
1- Space: Trong toàn văn bản, không cho phép có 2 space liền nhau.
Macro xóa các khoảng trống thừa:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Sub XóaKhoangTrông()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "  "
        .Replacement.Text = " "
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Forward = True
        .Wrap = wdFindContinue
    End With
    Selection.Find.Execute Replace=wdReplaceAll
End Sub
GeSHi © Codebox Plus Extension

Bạn chú ý 2 dòng code liên tiếp:
MÃ: CHỌN TẤT CẢ

.Text = "  " '(2 space) 
.Replacement.Text = " " '(1 space)
2- Dấu phẩy: buộc dính sát với ký tự cuối đoạn văn (phrase), kế tiếp là một space. Ký tự tiếp theo là ký tự thường.
2a) Macro chỉnh sửa dấu phẩy dạng abc , def
Dùng code như Sub XóaKhoangTrông; thay thế các đối số .Text và .Replacement.Text
MÃ: CHỌN TẤT CẢ

.Text = " ," '(space và phẩy) 
.Replacement.Text = "," '(phẩy)
2b) Macro chỉnh sửa dấu phẩy dạng abc,def
Thay thế các đối số:
MÃ: CHỌN TẤT CẢ

.Text = "," '(phẩy) 
.Replacement.Text = ", " '(phẩy và space)
2c) Khi chạy macro 2b, các trường hợp dấu phẩy đúng abc, def sẽ biến thành sai abc, def (2 space). Lúc nầy ta chạy Sub XóaKhoangTrông là xong.

3- Dấu chấm: buộc dính sát với ký tự cuối câu (sentence, paragraph). Kết thúc câu (sentence) với 1 space, kết thúc đoạn văn (paragraph) là xuống dòng. Ký tự nối tiếp bao giờ cũng là ký tự HOA.
Macro chỉnh sửa dấu chấm không xuống dòng tương tự macro dấu phẩy, ta thay dấu phẩy thành dấu chấm.

4- Dấu ngoặc đơn: gồm đơn mở và đơn đóng.
- Đơn mở bao giờ cũng dính sát với ký tự đầu tiên.
- Đơn đóng bao giờ cũng dính sát với ký tự cuối cùng.
ví dụ: abc (def).
Các dấu đóng mở khác quy định tương tự dấu ngoặc đơn; vd: abc "def"; abc [def]; abc 'def' và abc {def}
4a) Macro sửa đơn mở: đơn giản.
MÃ: CHỌN TẤT CẢ

.Text = "( "
.Replacement.Text = "("
4b) Đơn đóng: tương tự.
MÃ: CHỌN TẤT CẢ

.Text = " )"
.Replacement.Text = ")"
Còn tiếp
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
thanhphongialy
Thành viên chính thức
Thành viên chính thức
Bài viết: 12
Ngày tham gia: Chủ nhật 29/04/2012 9:03 am
Been thanked: 3 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by thanhphongialy » Thứ 5 24/05/2012 10:53 am

Chỉ bảo rất cặn kẻ, tận tình, chu đáo. Các bạn đã được giúp hãy giới thiệu bác truongphu với chương trình "Hiệp Sĩ CNTT" của e chíp hoặc các chương trình tương tự, nhằm tôn vinh những người vì cộng đồng (lĩnh vực CNTT) như bác ý!
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by truongphu » Thứ 5 24/05/2012 6:16 pm

thanhphongialy đã viết:
với chương trình "Hiệp Sĩ CNTT"
chi mà! :-$
cảm ơn lời động viên
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
MS Word abc.
Gửi bài by truongphu » Thứ 5 24/05/2012 6:19 pm

Tiếp theo

5- Dấu hỏi: buộc dính sát với ký tự cuối câu. Dấu hỏi giá trị ngắt câu tương đương dấu chấm, vì thế sau dấu hỏi không thêm dấu chấm.
vd: abc? Def
ví dụ trên, dấu hỏi dính liền ký tự c, và ký tự D buộc viết HOA vì xem đã ngắt câu. Không có dấu chấm kèm.

macro sửa cũng tương tự:
MÃ: CHỌN TẤT CẢ

.Text = " ?"
.Replacement.Text = "?"
6- Dấu than: buộc dính sát với ký tự cuối câu. Dấu than giá trị ngắt câu tương đương dấu chấm, vì thế sau dấu than không thêm dấu chấm.
vd: abc! Def
ví dụ trên, dấu than dính liền ký tự c, và ký tự D buộc viết HOA vì xem đã ngắt câu. Không có dấu chấm kèm.

macro sửa cũng tương tự:
MÃ: CHỌN TẤT CẢ

.Text = " !"
.Replacement.Text = "!"
hoặc
MÃ: CHỌN TẤT CẢ

.Text = "!. "
.Replacement.Text = "!"
7- Dấu hai chấm: buộc dính sát với ký tự cuối từ.
vd: abc: def
macro sửa cũng tương tự:
MÃ: CHỌN TẤT CẢ

.Text = " :"
.Replacement.Text = ":"
8- Dấu ba chấm: buộc dính sát với ký tự cuối từ, không quy định số lượng dấu chấm, nhưng thường chỉ 3 chấm là đủ:
vd: abc... def

9- Xuống dòng: Không quy định số lượng xuống dòng.
* Ký tự đầu dòng buộc phải viết hoa, trừ trường hợp đặc biệt.
* Ký tự đầu dòng viết ở đầu dòng, hoặc thụt vào 1 space, hoặc thụt vào 1 tab theo trình bày của mỗi người.
Nếu xuống dòng không viết gì (dòng trống) mà có thụt vào (space hay tab) là không đúng quy định.

Xóa nhiều xuống dòng với bảng Find and Replace:
Find: ^p^p
Replace: ^p
Macro:
MÃ: CHỌN TẤT CẢ

.Text = Chr(10)  & Chr(13) & Chr(10)  & Chr(13)
.Replacement.Text = Chr(10)  & Chr(13)
Xóa thụt vào 1 space: Đôi lúc xóa nhiều xuống dòng như trên thấy không thay đổi là do xuống dòng có thụt vào.
Find: ^p
Replace: ^p
(ở Find, sau ^p có một space)
Macro:
MÃ: CHỌN TẤT CẢ

.Text = Chr(13) & " "
.Replacement.Text = Chr(13)
(sắp tới viết về tìm và xóa)
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Dùng Find Wildcards để chuyển Ucase thành Pcase
Gửi bài by truongphu » Thứ 6 29/06/2012 1:26 pm

Dùng Find Wildcards để chuyển Upper case thành Proper case

Nội dùng ví dụ, Trích từ câu hỏi:
viewtopic.php?f=15&t=23657#p126657
Literaturverzeichnis.
Gesamtdarstellungen.
Abstracts of the Journal of Metals. London : The Institut of Metals.
COTTRELL, A. H. : Theoretical Structural Metallurgie. London 1951.
Dehlinger, U. : Chemische Physik der Metalle und Legierungen. Leipzig 1939.
FRÖHLICH, H.: Elektronentheorie der Metalle. Berlin 1936.
HUME-ROTHERY, W. : Atomic Theory for Students of Metallurgy. London 1952.
MOTT, N. F., u. H. JONES: The Theory of the Properties of Metals and Alloys. Oxford 1936.
RAYNOR, G. V.: An Introduction to the Electron Theory of Metals. 1947.
SEITZ, F. : The modern Theory of Solids. New York u. London 1940.
SOMMERFELD, A., u. H. BETHE : Hdb. d. Physik, 2. Aufl., Bd. 24, 2. Berlin 1933.
MASING, G. : Lehrbuch der allgemeinen Metallkunde. Berlin/Göttingen/Heidelberg 1951.
BOAS, W. : An Introduction to the Physics of Metals and Alloys. London 1947.
Code sau đây sẽ chuyển các từ như COTTRELL thành Cottrell ..
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Sub CommandButton1_Click()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    Dim ZZZZ As Range, MMMM$
    With Selection.Find
        .Text = "[A-Z]*>"
        .MatchCase = False
        .MatchWholeWord = True
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Wrap = wdFindContinue
    End With
        Do While Selection.Find.Execute _
        (Replace=wdReplaceNone, Forward=True) = True
            Set ZZZZ = ActiveDocument.Range _
            (Start=Selection.Start, End=Selection.End)
            If Mid(ZZZZ.Text, 2, 1) = UCase(Mid(ZZZZ.Text, 2, 1)) And Len(ZZZZ.Text) > 1 Then
                MMMM = StrConv(ZZZZ.Text, vbProperCase)
                ZZZZ = MMMM
                ZZZZ.Font.Color = wdColorDarkRed
            End If
            Selection.MoveRight wdWord, 1, wdMove
        Loop
End Sub
GeSHi © Codebox Plus Extension


Project = File Doc 2003 có VBA
TẬP TIN ĐÍNH KÈM
Wildcards ProperCase.rar
(10.73 KiB) Đã tải về 357 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
wan
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 2 17/10/2011 10:51 am
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by wan » Thứ 6 29/06/2012 8:03 pm

Trước hết là cảm ơn anh đã giúp e ở vấn đề trên(Việc chuyển font chữ hoa thành Proper Case). Sau là a làm ơn giúp e thêm 1 vấn đề về thay thế trên word nữa là:
+E có một tài liệu có các mã chữ: "& # x 0 0 D 6;" "& # x 0 0 A 7;" "& # x 0 0 F C;"......(các chữ trong ngoặc kép không có dấu cách). Các chữ này khi ở trên word nếu ấn alt+x thì nó sẽ chuyển về dạng chữ chứ không phải dạng mã. E định sử dụng code bên phía trên của anh để tự động search và chuyển lại các ký tự này {.Text = "[A-Z]*>"} thành {&#x[0-9A-F]{4,5};} nhưng k chuyển đổi dc. A có thể giúp e vấn đề này dc không.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by truongphu » Thứ 6 29/06/2012 10:12 pm

wan đã viết:
chuyển lại các ký tự này {.Text = "[A-Z]*>"} thành {&#x[0-9A-F]{4,5};} nhưng k chuyển đổi dc.
Câu trên nghĩa là sao? Ý bạn diễn tả:
thay vì mẫu tìm là [A-Z]*> bạn thế bằng mẫu tìm {&#x[0-9A-F]{4,5};}

Viết như thế đương nhiên không đúng vì
Nếu là mẫu tìm bạn đã không để ý dấu space giữa chúng

Bạn tìm là: & # x 0 0 D 6;
mẫu tìm sẽ là:
MÃ: CHỌN TẤT CẢ

.Text = "(&) (#) (x) ([0-9A-F]) ([0-9A-F]) ([0-9A-F]) ([0-9A-F])(;)"
Không viết rút gọn để phục vụ việc xóa space ở mẫu thế
Mẫu thế sẽ là:
MÃ: CHỌN TẤT CẢ

.Replacement.Text = "\1\2\3\4\5\6\7\8"
(Nếu thích loại cả dấu kép ", bạn có thể thêm vào code...)

Đây là code:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Sub CommandButton2_Click()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "(&) (#) (x) ([0-9A-F]) ([0-9A-F]) ([0-9A-F]) ([0-9A-F])(;)"
        .MatchCase = False
        .MatchWholeWord = True
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Wrap = wdFindContinue
        .Replacement.Text = "\1\2\3\4\5\6\7\8"
    End With
    Selection.Find.Execute Replace=wdReplaceAll
End Sub
GeSHi © Codebox Plus Extension


Code nầy dùng Find.Execute Replace vì mẫu thay thế viết êm, do độ dài text thay thế cố định = 8 ký tự

OK chưa?
Bạn đang làm nghề gì thế? hay sv? mà sv đâu có học được vba nầy?

TB: nếu bạn thay ĐƯỢC với ([0-9A-F]){4} thì code sẽ gọn hơn; tôi thử chưa êm
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
wan
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 2 17/10/2011 10:51 am
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by wan » Thứ 7 30/06/2012 9:42 pm

CẢm ơn anh. E làm dạng như kiểu gia công phần mềm thôi(cụ thể là sử dụng các chương trình như omnipage + abbyy để OCR txt và edit lại mà). Vì tài liệu gần đây nó có nhiều kt đặc biệt và phải check và đổi lại bằng tay nên mới mày mò tìm hiểu 1 chút mà.
-Còn code trên có vẻ như e chưa diễn tả đúng để nhờ anh giúp rồi:
+Em có đính kèm 1 tập tin notepad. Anh có thể giúp em code mà chuyển các ký tự dạng mã(vd:&.#.x.0.0.F.C - không có dấu . giữa các chữ. thành dạng unicode chính xác không. Vd trên word khi ấn alt+x thì 0.0.F.C nó sẽ chuyển thành "ü" cái này e phải search từng chữ rồi ấn alt+x để nó chuyển lại đúng). Còn cái code chuyển KT hoa thành dạng thường e dùng rất tốt. Cảm ơn anh nhiều
TẬP TIN ĐÍNH KÈM
content_BM_241-248.zip
(7.32 KiB) Đã tải về 324 lần
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by truongphu » Thứ 7 30/06/2012 11:58 pm

Hình minh họa:
untitled.JPG
Code:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Sub CommandButton1_Click()
    Dim ZZZZ As Range, MMMM$
    With Selection.Find
        .Text = "&#x[0-9A-F]{4};"
        .MatchWildcards = True
        .Wrap = wdFindContinue
    End With
        Do While Selection.Find.Execute _
        (Replace=wdReplaceNone, Forward=True) = True
            Set ZZZZ = ActiveDocument.Range _
            (Start=Selection.Start, End=Selection.End)
                MMMM = Mid(ZZZZ.Text, 4, 4)
                ZZZZ = ChrW(CLng("&H" & MMMM))
                ZZZZ.Font.Color = wdColorViolet
            Selection.MoveRight wdWord, 1, wdMove
        Loop
End Sub
GeSHi © Codebox Plus Extension


Word 2003:
TẬP TIN ĐÍNH KÈM
Literaturverzeichnis.rar
(16.42 KiB) Đã tải về 334 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Chuyển text m/d/y thành text d/m/y
Gửi bài by truongphu » Chủ nhật 01/07/2012 6:04 pm

Trong các file dịch từ tiếng nước ngoài, việc chuyển định dạng tháng/ngày/năm thành ngày/tháng/năm là cần thiết và thường gặp.
Vì có thể ngày tháng trong văn bản có nhiều dữ liệu khác nhau, đo đó ta phải dùng MatchWildcards = True
vd:
Ddd 2/25/1999 xxxx hhhh
Eeee tttt 6/14/2006
3/30/1998 pppp kkkk 7/27/2010
Mẫu tìm chung sẽ là: "([0-9]{1,2})/([0-9]{1,2})/([0-9]{4})"
Mẫu thay sẽ là: "\2/\1/\3"

Code:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Sub CommandButton1_Click()
    With Selection.Find
        .MatchCase = False
        .MatchWildcards = True
        .Wrap = wdFindContinue
        .Text = "([0-9]{1,2})/([0-9]{1,2})/([0-9]{4})"
        .Replacement.Text = "\2/\1/\3"
        .Replacement.Font.Color = wdColorBrown
        .Execute Replace=wdReplaceAll
    End With
End Sub
GeSHi © Codebox Plus Extension


Một số bạn quen chạy macro, thấy Private Sub CommandButton1_Click khá bỡ ngỡ;
Thật ra các bạn có thể copy nội dung trong Private Sub CommandButton1_Click để làm Macro mới và chạy vẫn nguyên kết quả, Vd:
MÃ: CHỌN TẤT CẢ

Sub Macro1()
    With Selection.Find
        .MatchCase = False
        .MatchWildcards = True
        .Wrap = wdFindContinue
        .Text = "([0-9]{1,2})/([0-9]{1,2})/([0-9]{4})"
        .Replacement.Text = "\2/\1/\3"
        .Replacement.Font.Color = wdColorBrown
        .Execute Replace:=wdReplaceAll
    End With
End Sub
MS Word 2003:
Chuyên m-d-y thành d-m-y.rar
(8 KiB) Đã tải về 331 lần
Hay không? >:D<
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
wan
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 2 17/10/2011 10:51 am
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by wan » Thứ 4 04/07/2012 10:48 am

Cảm ơn anh nhiều ạ, code của anh dùng tốt lắm.

Vd e có 1 đoạn như thế này:

Ηλιάδου A., «Ο ρόλος του κράτους στην αγορά ενέργειας και η Ρυθμιστική Αρχή Ενέργειας», Πρακτικά Ημερίδας με θέμα «Απελευθέρωση της Αγοράς Ηλεκτρικής Ενέργειας» του Κέντρου Διεθνούς και Ευρωπαϊκού Οικονομικού Δικαίου, Εκδ. Αντ. Ν. Σάκκουλα, Αθήνα - Κομοτηνή 2001, 57 et seq.

Đây là tiếng greek, e muốn chuyển đổi sang dạng mã như ở bên trên( vd: &#xXXXX;) a có thể giúp e code dc không ạ.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về VBA/MS Word (2003) (*)
Gửi bài by truongphu » Thứ 4 04/07/2012 3:10 pm

wan đã viết:
Đây là tiếng greek, e muốn chuyển đổi sang dạng mã như ở bên trên( vd: &#xXXXX;)
Câu hỏi nầy không phải VBA mà thuần VB6.
Bạn chỉ việc dùng hàm AscW đọc từng ký tự là xong. Dùng hàm Hex chuyển.

Cần TextBox1 (Forms 2.0 hổ trợ unicode); khi chạy dán đoạn văn trên vào.
cần Text1 (chuẩn) và Command1:

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Sub Command1_Click()
Dim i&, MM$
For i = 1 To Len(TextBox1.Text)
    MM = MM & "&#x" & Format(Hex(AscW(Mid(TextBox1.Text, i, 1))), "00#") & ";"
Next
Text1 = MM
End Sub
GeSHi © Codebox Plus Extension


Còn nếu muốn giữ nguyên các ký tự ASCII quen thuộc:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Sub Command1_Click()
Dim i&, MM$, UU$
For i = 1 To Len(TextBox1.Text)
    If AscW(Mid(TextBox1.Text, i, 1)) > 127 Then
        UU = Format(Hex(AscW(Mid(TextBox1.Text, i, 1))), "00#")
        If Len(UU) < 4 Then UU = String(4 - Len(UU), "0") & UU
        MM = MM & "&#x" & UU & ";"
    Else
        MM = MM & Mid(TextBox1.Text, i, 1)
    End If
Next
Text1 = MM
End Sub
GeSHi © Codebox Plus Extension


Rãnh nên học VB6 (hay VBA cũng thế) sẽ rất thú vị và thiết thực trong cuộc sống.

http://www.nhaccuatui.com/m/d1wuTAl0Epym
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Tách ngày tháng
Gửi bài by truongphu » Thứ 5 12/07/2012 2:35 pm

Ở trên các bạn đã làm quen đổi m/d/y thành d/m/y trong đó quan trọng là mẫu tìm và mẫu thế.
Bài viết nầy cũng để minh hoa việc tìm các mẫu ngày tháng và thế.

VD ta có đoạn văn sau:
Danh sách quý vị hảo tâm…

Ông Nguyễn văn A Ngày 25/10/2009
Bà Lê thị Y Ngày 6/11/2009
Bà Bùi Hoa H Ngày 14/7/2010
Ông Võ X Ngày 9/7/2011
Bà Lê thị Y Ngày 6/11/2011
Ông Võ X Ngày 2/3/2012
Bà Lý Thanh M Ngày 12/4/2012
Bà Hoàng thị L Ngày 6/7/2012
Yêu cầu là tách năm đuôi thành một cột để dễ nhìn và dễ tổng kết từng năm:
2.jpg
2.jpg (26.54 KiB) Đã xem 10050 lần
Word 2003 và code
Tách ngày tháng.rar
(9.04 KiB) Đã tải về 369 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Chủ nhật 29/07/2012 1:10 pm

Thời gian tới
tôi sẽ sẵn sàng trao đổi với các bạn
về tìm và thay thế
dùng wiildcard

Các bạn cứ yêu cầu về mẫu tìm và tay,
nếu tôi có lên mạng, sẽ trả lời nhanh nhất :-w
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
207 bài viết    2    …  
Quay về
Trang chủDiễn đànThời gian được tính theo giờ UTC+07:00 UTC+7Xoá cookie của websiteLiên hệ chúng tôi
Đã tích hợp phpBB® Forum Software © phpBB Limited

Vietnamese language pack for phpBB 3.2.x download and support.

PRIVACY_LINK | TERMS_LINK

Page 3

Câu lạc bộ Visual Basic
.:: Nơi trao đổi về ngôn ngữ Visual Basic ::.

Bỏ qua nội dung

Nhập từ khóa tìm kiếm…
Đường dẫn nhanhTrợ giúpĐăng nhập
Trang chủDiễn đànTHẮC MẮC - TRAO ĐỔI - THẢO LUẬNVisual Basic for Application (VBA)
Trao đổi về Word VBA Mời vào đây!
Điều hành viên: tungblt

Nội quy chuyên mục

Tìm kiếm trong chủ đề này…
207 bài viết     3   …  
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Viết Hoa sau dấu chấm câu.
Gửi bài by truongphu » Thứ 2 30/07/2012 7:39 am

Viết Hoa sau dấu chấm câu.

Thông thường tìm một chuỗi ký tự và thay bằng một chuỗi ký tự khác thì quá dễ! Nhưng rõ ràng hành động nầy chỉ thích đáng cho một trường hợp riêng biệt.

Nếu yêu cầu cho một trường hợp chung, vd: Viết Hoa sau dấu chấm câu, thì không thể tìm và thay thế như ở trên được, vì sau dấu chấm câu các ký tự sẽ khác nhau. Trường hợp chung nầy người ta dùng Wildcard để tìm.

Ta làm quen vài ký hiệu tìm dùng trong Wildcard sẽ sử dụng trong code tiếp theo sau:
Cặp dấu đóng vuông []
là khai báo chỉ 1 ký tự trong đó.
vd: [a] là tìm 1 ký tự a
vd: [a-z] là tìm 1 ký tự bất kỳ từ a đến z; ký tự thuộc ASCII
Vậy mẫu tìm ta sẽ viết là: ". [a-z]"
Trong mẫu tìm trên, bạn sẽ đọc được là dấu chấm, space và một ký tự thường bất kỳ a-z

Mẫu thế: Mẫu thế ở đây không thể khai báo cố định.
Khi chúng tìm được (mẫu tìm), ta cho mẫu thế là upper case mẫu tìm.
Kết quả: dấu chấm, upper case nó cũng là dấu chấm, tương tự cho space.
Riêng [a-z] vì Ucase sẽ biến thành [A-Z]

Thế là xong. Mời các bạn chạy Sub sau đây:
MÃ: CHỌN TẤT CẢ

Sub HOAsauChâm()
    With Selection.Find
        .ClearFormatting
        .Text = ". [a-z]"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Execute
        While .Found
            Selection.Range.Case = wdUpperCase
            Selection.Collapse Direction:=wdCollapseEnd
            .Execute
        Wend
    End With
End Sub
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Xóa từ và đảo lộn từ
Gửi bài by truongphu » Thứ 2 30/07/2012 1:42 pm

Vd truyện chuyển ngữ (dịch thô) của Tàu thường thấy:

Đệ 025 chương Mò kim đáy bể

aaa bbb

Đệ 026 chương Bút sa gà chết

ccc ddd
Yêu cầu là xóa chữ Đệ (chỉ) trong các câu tiêu đề chương, sau đó đưa từ chương ra trước và viết hoa ký tự đầu.
kết quả yêu cầu như sau:

Chương 025 Mò kim đáy bể

aaa bbb

Chương 026 Bút sa gà chết

ccc ddd
Ở đây ta cũng phải dùng Wildcard vì mẫu tìm thay đổi.
Vd như trong tiêu đề chương: Đệ 025 chương Mò kim đáy bể, ta chỉ tìm nhóm tương tự như Đệ 025 chương. Đoạn văn sau không cần tìm.

* Bạn để ý thấy chữ Đệ luôn luôn đầu dòng, vậy để tìm thêm chính xác, ta bắt đầu bằng dấu xuống dòng.
* các ký tự unicode không viết được vào code, ta có thể thay bằng dấu hỏi

Ta làm quen vài ký hiệu tìm dùng trong Wildcard sẽ sử dụng trong code tiếp theo sau:

Cặp dấu ngoặc đơn () là khai báo từ hay nhóm từ trong đó.
Vd (abc) là tìm nhóm từ abc

Ký hiệu ^13 là ký hiệu xuống dòng

Ký hiệu dấu hỏi ? tượng trưng 1 ký tự nào đó (ACII hay Unicode).

Cặp dấu đuôi {} là mô tả số lần ký tự ở trước

Ta viết mẫu tìm chung như sau: "(^13)(?? )([0-9]{3} )(c)(h??ng )"

Bạn thấy trong mẫu tìm có 5 nhóm ngoặc đơn
- nhóm 1 là xuống dòng
- nhóm 2 thế chữ Đệ (không viết trong code được), có space ở sau
- nhóm 3 là ký tự số từ 0-9 và có 3 số như vậy, sau có space
- nhóm 4 là ký tự c
- nhóm 5 là chữ hương, 2 dấu ?? thế ươ
sau có space

Mẫu thay ta viết luôn, đó là:
"\1C\5\3"

=> dấu chéo \ kèm số, vd \1 sẽ lấy nhóm 1 ở mẫu tìm
C là ký tự C (HOA)

Vậy mẫu thế "\1C\5\3" ta sẽ hiểu là:
\1: giữ nguyên xuống dòng
C: Ký tự C đầu dòng
\5: thêm chữ hương
\3: nhóm số chương tìm được

Trong mẫu thế không có \2 nghĩa là chữ Đệ không dùng.
Cũng không cần \4 do chữ c ta đã chủ động ghi C trong mẫu thế

Code toàn vẹn như sau:
MÃ: CHỌN TẤT CẢ

Sub Chuongxxx()
    With Selection.Find
        .ClearFormatting
        .Text = "(^13)(?? )([0-9]{3} )(c)(h??ng )"
        .Replacement.Text = "\1C\5\3"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Execute Replace:=wdReplaceAll
    End With
End Sub
Bạn có thể tải MS Word 2003 kèm ví dụ trên.
TẬP TIN ĐÍNH KÈM
wildcard xóa và chuyên nhóm.rar
(6.09 KiB) Đã tải về 366 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viênxuanha
Guru
Guru
Bài viết: 1230
Ngày tham gia: Thứ 5 19/08/2010 4:25 pm
Đến từ: Ban Tổ chức Thành uỷ Hưng Yên, tỉnh Hưng Yên
Has thanked: 13 times
Been thanked: 374 times
Tiếp xúc: Liên hệ xuanha
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by xuanha » Thứ 5 09/08/2012 11:32 am

Trong Word không cho phép thay thế đoạn văn bản có chứa ký tự xuống dòng hoặc không cho phép thay thế một đoạn văn bản thành đoạn văn bản có chứa ký tự xuống dòng. Em muốn là một đoạn code để khắc phục hạn chế trên của Word và cũng là liên quan đến công việc hàng ngày, nhưng vẫn chưa thành công, cụ thể:
1. Chỉ thay thế được một đoạn văn bản thành ký tự xuống dòng
2. Chỉ thay thế được ký tự xuống dòng thành một đoạn văn bản
Em đã đọc rất nhiều bài viết của bác Truongphu và thấy bác rất am hiểu và có kiến thức sâu về VBA. Trân trọng cảm ơn và đề nghị bác giúp đỡ em đoạn code thực hiện được yêu cầu sau:
Thay thế một đoạn văn bản có chứa ký tự xuống dòng thành một đoạn văn bản có chứa ký tự xuống dòng.
Kiểm phiếu Đại hội Đoàn, Đại hội Đảng
http://caulacbovb.com/forum/viewtopic.php?t=23599
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 5 09/08/2012 1:48 pm

1- Một đoạn có xuống dòng thành không xuống dòng

Mẫu tìm:
xuanha đã viết:
1. Chỉ thay thế được một đoạn văn bản thành ký tự xuống dòng
2. Chỉ thay thế được ký tự xuống dòng thành một đoạn văn bản
code là:
MÃ: CHỌN TẤT CẢ

.Text = "(1.*)(^13)(2.*)(^13)"
Thay thế, chỉ việc bỏ vị trí thứ 2 (^13 là xuống dòng)
MÃ: CHỌN TẤT CẢ

.Replacement.Text = "\1. \3\4"
trong mẫu thế, sau đoạn 1 thêm dấu chấm và space

2- Môt đoạn không xuống dòng thành xuống dòng

Mẫu tìm:
xuanha đã viết:
không cho phép thay thế đoạn văn bản có chứa ký tự xuống dòng hoặc không cho phép
MÃ: CHỌN TẤT CẢ

.Text = "(không cho phép*có)(*không cho phép)"
mẫu thế: chỉ thêm nhóm ^p
MÃ: CHỌN TẤT CẢ

.Replacement.Text = "\1^p\2"
trong mẫu thế, ^p chèn sau nhóm 1; mà kết thúc nhóm 1 là chữ có
Vậy sao chữ có sẽ xuống dòng. (ưng thêm dấu chấm cũng được)

Code toàn vẹn:
MÃ: CHỌN TẤT CẢ

Private Sub CommandButton1_Click()
    With Selection.Find
        .ClearFormatting
        .Text = "(1.*)(^13)(2.*)(^13)"
        .Replacement.Text = "\1. \3\4"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Execute Replace:=wdReplaceAll
    End With
End Sub

Private Sub CommandButton2_Click()
        With Selection.Find
        .ClearFormatting
        .Text = "(không cho phép*có)(*không cho phép)"
        .Replacement.Text = "\1^p\2"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Execute Replace:=wdReplaceAll
    End With
End Sub
TẬP TIN ĐÍNH KÈM
xuanha.rar
(9.17 KiB) Đã tải về 327 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viênxuanha
Guru
Guru
Bài viết: 1230
Ngày tham gia: Thứ 5 19/08/2010 4:25 pm
Đến từ: Ban Tổ chức Thành uỷ Hưng Yên, tỉnh Hưng Yên
Has thanked: 13 times
Been thanked: 374 times
Tiếp xúc: Liên hệ xuanha
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by xuanha » Thứ 5 09/08/2012 2:14 pm

Cám ơn bác Truongphu đã chỉ bảo, giúp đỡ.
Bác cho em hỏi, ngoài cách sử dụng mẫu thì còn cách nào khác không.
VD:
12/12
2002
=> 12/12/2002
hoặc
12/12/2002
=> 12/12
2002
Sử dụng 2 textbox để nhập chuỗi cần thay thế và chuỗi thay thế.
Kiểm phiếu Đại hội Đoàn, Đại hội Đảng
http://caulacbovb.com/forum/viewtopic.php?t=23599
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 5 09/08/2012 4:20 pm

Hình sau đây là project VB6:
untitled.JPG
Trong MS Word, Để phục vụ nhiều lần, bạn có thể xây dựng UserForm Chung tại Normal.dot
Code trên UserForm đơn giản hơn vì chúng đã có sẵn Application.
Hơn nữa các TextBox hổ trợ unicode nên việc tìm và thay qua TextBox đơn giản hơn nhiều.

Nói chung, code tìm và thay tương tự; chỉ khác mẫu tìm và mẫu thay.

Trong Project VB6 kèm theo, dùng hàm GetObject, nên bạn phải mở file Tìm và Thay.doc (đính kèm),
sau đó run project, sẽ tự động tìm...
TẬP TIN ĐÍNH KÈM
GetObject Word.Application.rar
(4.24 KiB) Đã tải về 369 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viênxuanha
Guru
Guru
Bài viết: 1230
Ngày tham gia: Thứ 5 19/08/2010 4:25 pm
Đến từ: Ban Tổ chức Thành uỷ Hưng Yên, tỉnh Hưng Yên
Has thanked: 13 times
Been thanked: 374 times
Tiếp xúc: Liên hệ xuanha
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by xuanha » Thứ 6 10/08/2012 9:53 pm

Lại phải làm phiền bác Truongphu lần nữa.
Em làm phần thay thế đoạn văn bản, nhưng gặp vướng mắc như sau:
1. Nếu là đoạn văn bản bình thường thì thay thế ngon (kể cả chứa ký tự xuống dòng).
2. Nếu là đoạn văn bản trong bảng thì xảy ra tỉnh trạng sau: Ký tự được thay thế bằng ký tự xuống dòng thì hiển thì là một khoảng cách (khoảng cách có mã Ascii là 13), nhưng khi convert bảng ra text thì lại xuống dòng.

Đoạn code thay thế như sau:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Sub CommandButton1_Click()
If Documents.Count = 0 Then Exit Sub
Dim x() As String
Dim x1() As String
x = Split(TextBox1.Text, vbCrLf)
x1 = Split(TextBox2.Text, vbCrLf)
With Selection.Find
        .ClearFormatting
        .Text = Join(x, Chr(13))
        .Replacement.Text = Join(x1, Chr(13))
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Execute Replace=wdReplaceAll
    End With
End Sub
GeSHi © Codebox Plus Extension

Kết quả làm như hình bên dưới.
Kính mong bác giúp đỡ em khác phục hiện tượng này.
TẬP TIN ĐÍNH KÈM
PNGfile.PNG
Kiểm phiếu Đại hội Đoàn, Đại hội Đảng
http://caulacbovb.com/forum/viewtopic.php?t=23599
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Chủ nhật 12/08/2012 7:55 am

* Ký tự space = Chr(32)
* Ký tự xuống dòng = Chr(13)
Trong một document MỚI của MS Word = chưa viết gì, sau dấu nháy con trỏ bao giờ cũng có Chr(13) mà ta thường không để ý.
Nếu chú ý và bôi đen nó, biểu hiện GIỐNG NHƯ là space (32)
Và đương nhiên, bất kể dòng nào, dù chưa xuống dòng, vị trí con trỏ cuối dòng bao giờ cũng kèm sẵn (13)

============
xuanha đã viết:
x = Split(TextBox1.Text, vbCrLf)
vbCrLf = vbCr + vbLf = xuống dòng và tạo dòng mới
vbCr = Chr(10) = dấu dòng mới
vbLf = Chr(13) = dấu xuống dòng

Chr(10) bao giờ cũng đi kèm với Chr(13). Để khỏi chú ý những rườm rà nầy, vbCrLf thay bằng vbNewLine
xuanha đã viết:
.Replacement.Text = Join(x1, Chr(13))
với lệnh trên, như đã nói, 10 bao giờ cũng kèm 13, VBA "thông minh" hiểu rằng bạn ghép chuỗi x1 với dấu xuống dòng, nên chúng "khuyến mãi" cặp 10-13
hệ quả: như bạn thấy...

* Nếu thay bằng space:
Join(x1, Chr(32))
* Nếu nối liền
Join(x1, "")
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viênxuanha
Guru
Guru
Bài viết: 1230
Ngày tham gia: Thứ 5 19/08/2010 4:25 pm
Đến từ: Ban Tổ chức Thành uỷ Hưng Yên, tỉnh Hưng Yên
Has thanked: 13 times
Been thanked: 374 times
Tiếp xúc: Liên hệ xuanha
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by xuanha » Chủ nhật 12/08/2012 9:56 am

Cám ơn bác đã tận tình giúp đỡ. Em làm theo cách sau thì ổn ngay:
.Text = Join(x, "^p")
.Replacement.Text = Join(x1, "^p")
Kiểm phiếu Đại hội Đoàn, Đại hội Đảng
http://caulacbovb.com/forum/viewtopic.php?t=23599
Đầu trang
VuongHung
Bài viết: 2
Ngày tham gia: Thứ 6 07/09/2012 3:46 pm
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by VuongHung » Thứ 6 07/09/2012 4:03 pm

Chao bác TruongPhu. Bác cho hỏi một chút về vấn đề này nha.
Tôi có gởi một file word mẫu, yêu cầu là sau khi nhập x,y,z thì nó sẽ tính ra kết quả và điền vào các mục kết quả a, kết quả b. Tôi thật sự không biết làm thế nào để lấy thông tin từ form để chèn vào word.
Mong bác giúp đở nha.
Cảm ơn bác.
TẬP TIN ĐÍNH KÈM
Testword.rar
(21.67 KiB) Đã tải về 299 lần
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 6 07/09/2012 5:01 pm

VuongHung đã viết:
yêu cầu là sau khi nhập x,y,z thì nó sẽ tính ra kết quả và điền vào các mục kết quả a, kết quả b. Tôi thật sự không biết làm thế nào để lấy thông tin từ form để chèn vào word.
Tôi đang dùng MS Word 2003 nên không biết các phiên bản sau nầy thế nào.
cách sau đây dựa trên W2003

1- Word: sau các hình công thức, vd hình 1, bạn gõ dấu = , rồi chèn bookmark tại vị trí đó.
Chèn bookmark tức là đánh dấu. tôi vd đánh dấu tên là kq
2- vào VBE
* Mục Project (tên file word), không phải mục Normal
- Bạn tạo một UserForm, vd đặt tên là Form1
- Nếu muốn vừa làm việc trên Form, vừa làm việc trên Word, bạn set ShowModal = False
- vẽ lên Form các textbox và command
* Để lúc mở document, Form sẽ hiện ngay, Tại ThisDocument của project, bạn viết:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Sub Document_Open()
    Form1.Show
End Sub
GeSHi © Codebox Plus Extension


* và để tính kết quả trên form, chèn vào Word, Form sẽ có code như sau:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Sub CommandButton1_Click()
    ActiveDocument.Bookmarks("kq").Range.InsertAfter _
    " " & (1 / 3) * Sqr(2 * Val(TextBox1.Text)) + Val(TextBox2.Text) - 3 * Val(TextBox3.Text)
End Sub
GeSHi © Codebox Plus Extension


Khi bạn mở file Word, hình sẽ hiện như sau:
untitled.JPG
untitled.JPG (7.81 KiB) Đã xem 9169 lần
File Word:
TẬP TIN ĐÍNH KÈM
Tính Kêt Qua MS Word 2003.rar
(7.4 KiB) Đã tải về 322 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
VuongHung
Bài viết: 2
Ngày tham gia: Thứ 6 07/09/2012 3:46 pm
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by VuongHung » Thứ 7 08/09/2012 10:37 am

Cảm ơn bác đã trả lời giúp, tôi còn một vấn đề nữa là nếu sử dụng insert after thì khi tính típ giá trị khác thì nó sẽ không xóa kết quả cũ. Vậy có cách nào khi nó insert giá trị mới thì tự động xóa giá trị cũ đi không ??
Tôi có thử sử dụng sub delete trước, nhưng như vậy khi chưa có giá trị gì thì nó sẽ nhảy dòng (giống như cuối dòng mình nhấn phím delete thì nó đưa dòng dưới lên.
Mong bác chỉ giáo giúp.
Cảm ơn nhiều.
Đầu trang
47abc
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 7 08/09/2012 11:13 pm
Has thanked: 20 times
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by 47abc » Thứ 7 08/09/2012 11:24 pm

Chào bác TruongPhu!
Mình gặp vấn đề trong việc lọc văn bản, không biết dùng VBA có giải quyết được không? Mong bác giúp đỡ.
Mình có một văn bản với nhiều đường link nằm lẫn trong đó. Mình muốn lọc các đoạn link này ra và copy sang cùng 1 chổ được không?
Mình có 2 ý tưởng:
-thiết kế code lọc được link??
-thiết kế code nhận diện một ký tự hay 1 cụm ký tự được nhập vào rồi lọc lấy cụm đó+thêm phía trước và phía sau bao nhiêu kí tự tùy mình muốn nữa??
đang cần cái này nhưng mỗi tội ko biết VBA:((, hôm h cày cuốc trên mạng mới bám víu được vào cái VBA này, hy vọng là được:D. Mong bác giúp mình nếu có thể
Cám ơn bác nhiều.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Chủ nhật 09/09/2012 8:46 am

VuongHung đã viết:
Vậy có cách nào khi nó insert giá trị mới thì tự động xóa giá trị cũ đi không ??
Bạn đã dùng delete, nảy dòng, thì bạn chèn thêm 1 dòng là xong:
MÃ: CHỌN TẤT CẢ

Private Sub CommandButton1_Click()
    ActiveDocument.Bookmarks("kq").Range.Select ' chon Ðánh dâu
    Selection.MoveEnd wdLine, 1 ' Chon Ðoan sau Ðó
    Selection.Delete ' xóa Ði
    Selection.InsertAfter vbCrLf ' Chèn xuông dòng và sau Ðó tính tiêp
    ActiveDocument.Bookmarks("kq").Range.InsertAfter _
    " " & (1 / 3) * Sqr(2 * Val(TextBox1.Text)) + Val(TextBox2.Text) - 3 * Val(TextBox3.Text)
End Sub
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Chủ nhật 09/09/2012 8:54 am

47abc đã viết:
văn bản với nhiều đường link nằm lẫn trong đó. Mình muốn lọc các đoạn link này ra và copy sang cùng 1 chổ
*** Cùng 1 chỗ: Bạn nhấn chuột vào document vị trí đã chọn. con trỏ nhấp nháy là vùng sẽ paste link
*** sau đó chạy macro sau:
MÃ: CHỌN TẤT CẢ

Sub CopyHyperlinks()
    Dim oField As Field
    For Each oField In ActiveDocument.Fields
    If oField.Type = wdFieldHyperlink Then
      oField.Copy
      Selection.Paste
    End If
    Next
    Set oField = Nothing
End Sub
47abc đã viết:
thiết kế code lọc được link??
ở trên
47abc đã viết:
thiết kế code nhận diện một ký tự hay 1 cụm ký tự được nhập vào
đấy là search. Code của search trong MS Word/VBA đã có nhiều. Bạn chịu khó đọc lại các bài trước trong chủ đề nầy...
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
47abc
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 7 08/09/2012 11:13 pm
Has thanked: 20 times
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by 47abc » Chủ nhật 09/09/2012 11:28 am

Cảm ơn bác:D. Để thử xem, sao không thấy nút cảm ơn vậy:(
Đầu trang
47abc
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 7 08/09/2012 11:13 pm
Has thanked: 20 times
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by 47abc » Chủ nhật 09/09/2012 11:41 am

Phương án đầu tiên nó copy mãi không dừng bác ơi! sau khi copy hết thì nó lọc lại từ đầu tiếp cho tới khi treo office luôn:((:((
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Chủ nhật 09/09/2012 12:18 pm

47abc đã viết:
nó copy mãi không dừng bác ơi! sau khi copy hết thì nó lọc lại từ đầu tiếp cho tới khi treo office luôn
ừ đúng thế, xin lỗi nghen :D
vì tạo ra hyperLink mới và hyperlink nầy mặc nhiên đưa vào vòng lặp nên vòng lặp hóa thành vô tận!

thì dùng:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub CopyHyperlinks()
    Dim oField As Field
    Dim MyData As New DataObject
    Dim ZZZ$
    For Each oField In ActiveDocument.Fields
    If oField.Type = wdFieldHyperlink Then
      oField.Copy MyData.GetFromClipboard
      ZZZ = ZZZ & MyData.GetText & vbCrLf
    End If
    Next
    Set oField = Nothing
    Selection.InsertAfter ZZZ
End Sub
GeSHi © Codebox Plus Extension


Phương án mới là danh sách đường dẫn nhưng không còn HyperLink. Đã test
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
47abc
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 7 08/09/2012 11:13 pm
Has thanked: 20 times
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by 47abc » Thứ 2 10/09/2012 11:02 pm

Phiền bác thêm lần nữa rồi!
Tình hình là mình chạy nhưng bị lỗi như sau
http://upanh.phimnhanh.net/viewer.php?f ... z_b68r.png
Mong bác xem thử@@
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 3 11/09/2012 7:28 am

Đã xem.
Bạn chưa dùng MS Form 2.0 (bộ Office) nên thiếu.

Thôi thì ráng:
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub CuôiCùngÐâyNha()
Dim S% S = ActiveDocument.Fields.Count
For S = 1 To S
    If ActiveDocument.Fields(S).Type = wdFieldHyperlink Then
        ActiveDocument.Fields(S).Copy
        Selection.Paste
        Selection.TypeParagraph
    End If
Next
End Sub
GeSHi © Codebox Plus Extension


nhấn con trỏ bên dưới docu, qua vbe và chạy sub nầy.
Sub nầy tựa Sub đầu tiên, khác là không dùng For Each mà dùng có giới hạn là For S=1 To
:P
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
207 bài viết     3   …  
Quay về
Trang chủDiễn đànThời gian được tính theo giờ UTC+07:00 UTC+7Xoá cookie của websiteLiên hệ chúng tôi
Đã tích hợp phpBB® Forum Software © phpBB Limited

Vietnamese language pack for phpBB 3.2.x download and support.

PRIVACY_LINK | TERMS_LINK

Page 4

Câu lạc bộ Visual Basic
.:: Nơi trao đổi về ngôn ngữ Visual Basic ::.

Bỏ qua nội dung

Nhập từ khóa tìm kiếm…
Đường dẫn nhanhTrợ giúpĐăng nhập
Trang chủDiễn đànTHẮC MẮC - TRAO ĐỔI - THẢO LUẬNVisual Basic for Application (VBA)
Trao đổi về Word VBA Mời vào đây!
Điều hành viên: tungblt

Nội quy chuyên mục

Tìm kiếm trong chủ đề này…
207 bài viết      4   …  
47abc
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 7 08/09/2012 11:13 pm
Has thanked: 20 times
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by 47abc » Thứ 3 11/09/2012 4:26 pm

Được rồi:D, cám ơn bác nhiều. Phiền bác quá
Đầu trang
47abc
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 7 08/09/2012 11:13 pm
Has thanked: 20 times
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by 47abc » Thứ 4 12/09/2012 6:49 pm

Chào bác truongphu, em lại phiền bác lần nữa. Em định tự tìm hiểu nhưng 2 ngày nay vẫn ko có kết quả. Mong bác giúp cho:)
Số là với code tìm và thay thế từ trong topic này http://caulacbovb.net/forum/viewtopic.p ... 8b#p120484 của bác, em sửa lại thành tìm-copy-paste sang file word khác. Xong định cho nó lặp hết văn bản nhưng không biết khai báo biến với tạo vòng lặp. Mong bác chỉ giúp em phần đó.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 5 13/09/2012 7:47 am

Chưa rõ ý bạn.
Nếu tìm-copy-paste thì không ý nghĩa
lặp hết văn bản là hằng wdReplaceAll

Bạn nên đưa một ví dụ đoạn text cụ thể, mẫu tìm, và muốn copy paste thế nào.
Và nhất là bạn cứ viết code, có thế mới góp ý được.
.
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
47abc
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 7 08/09/2012 11:13 pm
Has thanked: 20 times
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by 47abc » Thứ 5 13/09/2012 7:11 pm

ví dụ mình có đoạn sau:

123/abcdef/3456ghijklm
lkjh423/tyui/3476mnvb
Zxcvbnm123/assdfg/3456qwerty

mình muốn copy phần ở giữa 123/ và /3456 rồi paste sang file word khác

nhờ bác góp ý giúp
MÃ: CHỌN TẤT CẢ

Sub TimKiem()

  Windows("Document1").Activate
       Selection.Find.Text = "123/"
       Selection.Find.Execute
       Selection.Collapse Direction:=wdCollapseEnd
       Selection.MoveRight Unit:=wdCharacter, Count:=25, Extend:=wdExtend
     
     Dim MM$: MM = Selection.Text
     Selection.Collapse Direction:=wdCollapseEnd
     Dim NN$
     NN = InStr(1, MM, "/3456")
     MM = Left(MM, NN - 1)
   
Selection.Text = MM
Selection.Copy
Selection.Collapse Direction:=wdCollapseEnd
Selection.MoveRight Unit:=wdWord, Count:=1, Extend:=wdExtend
Windows("Document3").Activate
Selection.Paste
Selection.TypeParagraph
Windows("Document1").Activate

End Sub
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 6 14/09/2012 7:21 am

1- Vòng lặp là:
MÃ: CHỌN TẤT CẢ

Do While Selection.Find.Execute = True
'... làm gì (Mục 2-)
Loop
2- Bạn tìm 123/ cũng được, không cần Collapse, từ đấy cho dãn ra cả line (wdLine)
sau đó dùng split cắt với "/" ta được khúc giữa.
Dùng một biến string nối lại các khúc giữa

3- Ngoài loop, bạn Activate khác. Selection chỉ việc insert biến string trên là xong!

Bạn viết lại lại thử xem; có thể chưa êm thì sửa tiếp; chuyện đó là bình thường. Có như vậy tay nghề mới lên
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
47abc
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 7 08/09/2012 11:13 pm
Has thanked: 20 times
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by 47abc » Thứ 6 14/09/2012 9:21 am

Tình hình là bó tay:D. Mấy cái bác viết em không hiểu gì hết. Vào phần help của vba trong word có cái nó cũng ko hướng dẫn luôn.
Mà ý em là copy 2 dòng đầu và cuối trên kia thôi, dòng giữa khác nên em mới phải tìm 123/ đó
Đầu trang
47abc
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 7 08/09/2012 11:13 pm
Has thanked: 20 times
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by 47abc » Thứ 2 17/09/2012 1:51 pm

Mình làm được rồi. Nhờ dùng cái vòng lặp của bác, còn mấy cái dưới không hiểu:D:D. Bị nhược điểm là do dùng cái hàm Left ở trên nên nó ảnh hưởng đến văn bản gốc thôi. Dù sao cũng được rồi. Cám ơn bác nhiều:D:D
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 2 17/09/2012 3:51 pm

47abc đã viết:
Mình làm được rồi. Nhờ dùng cái vòng lặp của bác,
thế chứ
47abc đã viết:
còn mấy cái dưới không hiểu :D:
?
truongphu đã viết:
2- Bạn tìm 123/ cũng được, không cần Collapse, từ đấy cho dãn ra cả line (wdLine)
sau đó dùng split cắt với "/" ta được khúc giữa.
MÃ: CHỌN TẤT CẢ

Selection.Find.Text = "(123/)(*)(/3456)"
PasteText = Split(Selection.Text, "/")
truongphu đã viết:
Dùng một biến string nối lại các khúc giữa
MÃ: CHỌN TẤT CẢ

KêtQua = KêtQua & PasteText(1) & vbCrLf
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Sub CommandButton1_Click()
    ChungCho2Sub
    Set Newdocu = Application.Documents.Add
    Newdocu.SaveAs ThisDocument.Path & "\PasteDoc" & Int(Rnd * 100) & ".doc"
    ThisDocument.Activate
    Selection.Find.Text = "(123/)(*)(/3456)"
    Dim PasteText() As String, KêtQua$
    Do While Selection.Find.Execute _
        (Replace=wdReplaceNone, Forward=True) = True
        Selection.Copy
        PasteText = Split(Selection.Text, "/")
        KêtQua = KêtQua & PasteText(1) & vbCrLf
        Selection.MoveRight wdWord, 1, wdMove
    Loop
    Newdocu.Activate
    Selection.InsertAfter KêtQua
    Newdocu.Save
End Sub
 
Sub ChungCho2Sub()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Wrap = wdFindContinue
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Randomize
End Sub
GeSHi © Codebox Plus Extension


====
Rõ ràng chưa? Bây giờ bạn xem code sẽ "nâng cao" nhiều...
Bạn phải nhấn nút cảm ơn ở trên 100 lần mới đủ đấy nhá

VBA toàn vẹn 2 cách:
paste sang file word khác Word-2003.rar
(11.06 KiB) Đã tải về 348 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
47abc
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 7 08/09/2012 11:13 pm
Has thanked: 20 times
Been thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by 47abc » Thứ 2 17/09/2012 9:21 pm

truongphu đã viết:
Rõ ràng chưa? Bây giờ bạn xem code sẽ "nâng cao" nhiều...
Bạn phải nhấn nút cảm ơn ở trên 100 lần mới đủ đấy nhá
Hình ảnhHình ảnhx100000 lần:D:D, giờ mình mới thấy nút cảm ơn, nhỏ quá mấy bữa không thấy:))
làm được thấy vui hẳn bác ah. để mình thử cái bác mới chỉ:D
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Thứ 6 21/09/2012 11:28 am

Chào các anh chị trên diễn đàn và anh truongphu.
Tôi mới tham gia diễn này và đang muốn viết 1 code tìm ký tự "=" trên file word.
Nhưng đang thắc mắc như sau:
1/ Làm sao lấy được số trang tìm thấy.
2/ Và cách nào gán kết quả tìm thấy vào trang cuối file hiện hành hay file word khác.
Code như sau:
MÃ: CHỌN TẤT CẢ

Sub Tim()
Application.ScreenUpdating = False
Dim sTxt$, rTxt$
Dim i&, iDong&, DoDai&, sodong&, sotrang&
sTxt = "="
'So dong cua file
sodong = ActiveDocument.Paragraphs.Count
'So trang
ActiveDocument.Repaginate
sotrang = ActiveDocument.BuiltInDocumentProperties(wdPropertyPages)
''For iDong = 1 To sodong
''Next iDong
For Each doan In ActiveDocument.Paragraphs
  iDong = iDong + 1
  If InStr(doan, sTxt) Then
    DoDai = doan.Range.Characters.Count
    For i = 1 To DoDai
      If doan.Range.Characters(i) = sTxt Then
        rTxt = rTxt & iDong & ";" & i
      End If
    Next i
    rTxt = rTxt & Chr(10)
  End If
Next doan
MsgBox rTxt
Application.ScreenUpdating = True
End Sub
Xin cám ơn, do mới tham gia nên có gì sai trong post bài nhờ anh chị hướng dẫn.
Và xin HD nút cám ơn.
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Viết Hoa sau dấu chấm câu.
Gửi bài by Thunghi » Thứ 6 21/09/2012 11:54 am

truongphu đã viết:
Viết Hoa sau dấu chấm câu.

Thông thường tìm một chuỗi ký tự và thay bằng một chuỗi ký tự khác thì quá dễ! Nhưng rõ ràng hành động nầy chỉ thích đáng cho một trường hợp riêng biệt.
Tôi cũng đang học viết 1 code tìm như sau:
1/ Sau dấu chấm là viết hoa và có 1 blank
2/ Trước dấu chấm và , thì không có khoản trắng.
Hiển thị kết quả tìm thấy gồm trang số và dòng số tìm thấy vào 1 file word khác.
Xin cám ơn.
Mới tìm hiểu và tìm ra nút "Cám ơn"
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 6 21/09/2012 3:10 pm

Thunghi đã viết:
Tôi cũng đang học viết 1 code tìm như sau:
1/ Sau dấu chấm là viết hoa và có 1 blank
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub HOASauChâm()
    With Selection.Find
        .ClearFormatting
        .Text = ". [a-z]"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Execute
        While .Found
            Selection.Range.Case = wdUpperCase
            Selection.Collapse Direction=wdCollapseEnd
            .Execute
        Wend
    End With
End Sub
GeSHi © Codebox Plus Extension

Thunghi đã viết:
2/ Trước dấu chấm và , thì không có khoản trắng.
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Public Sub SpaceAll(StrFi As String, strRe As String, Optional ByVal Loai As Integer = 0)
    On Error Resume Next
    With Selection.Find
        .ClearFormatting
        .Replacement.ClearFormatting
        Select Case Loai
            Case 0
            Case 1 .Replacement.Font.Italic = True 'italic
           Case 2 Selection.Find.MatchCase = True ' Hoa
           Case 3 Selection.Find.MatchCase = True '-> thuong
           Selection.Find.Replacement.Font.Italic = False
            Selection.Find.Replacement.Font.Color = wdColorAutomatic
        End Select
        .MatchWildcards = False
        .Text = StrFi
        .Replacement.Text = strRe
        .Execute Replace=wdReplaceAll
       
        ' phuc hôi cho lâ`n tiêp default
       .ClearFormatting
        .Replacement.ClearFormatting
        .Forward = True
        .Wrap = wdFindContinue
        .MatchCase = False
        '.Replacement.Font.Italic = False
       '.Replacement.Font.Bold = False
       '.Replacement.Font.Color = 0
    End With
End Sub
GeSHi © Codebox Plus Extension


MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub Xoa2Space() ' Xóa 2 space all
   SpaceAll "  ", " "
End Sub
 
Sub Xoa2XuongHang() ' Xóa 2 xuông hàng toàn bô
   SpaceAll "^p^p", "^p"
End Sub
 
Sub XoaXuongHang() ' Xóa xuông hàng thành 1 câu
   On Error Resume Next
    Selection.InsertAfter " " ' chèn space
   Selection.MoveRight unit=character, Count=1, Extend=wdMove
    Selection.Move wdSentence, 1 ' move 1 câu
   Selection.TypeBackspace
End Sub
 
Sub XoaSpaceCuoicau() ' xóa space cuôi câu
   SpaceAll " ^p", "^p"
End Sub
 
Sub XoaSpaceÐaucau() ' xóa space Ðâu câu
   SpaceAll "^p ", "^p"
End Sub
 
Sub XoaSpTruocThan() ' Xóa space truoc dâu than !
   SpaceAll " !", "!"
End Sub
 
Sub XoaSpSauThan() ' Xóa space giua 2 dâu ! "
   SpaceAll "! """, "!"""
End Sub
Sub XoaTruocPhay() ' Xóa space truoc dâu phây ,
   SpaceAll " ,", ","
End Sub
 
Sub XoaTruocCham() ' Xóa space truoc dâu châm .
   SpaceAll " .", "."
End Sub
 
Sub XoaTr2Cham() ' Xóa space truoc 2 châm
   SpaceAll " ", ""
End Sub
 
Sub XoaSpTruHoi() ' Xóa space truoc dâu hoi ?
   SpaceAll " ?", "?"
End Sub
 
Sub XoaSpSauHoi() ' Xóa space giua 2 dâu ? "
   SpaceAll "? """, "?"""
End Sub
GeSHi © Codebox Plus Extension

Thunghi đã viết:
Hiển thị kết quả tìm thấy gồm trang số và dòng số tìm thấy vào 1 file word khác.
Trang số nơi Selection hoạt động:
Selection.Information(wdActiveEndPageNumber)

Đoạn văn (paragraph) nơi Selection hoạt động:
MÃ: CHỌN TẤT CẢ

For i = 1 To ActiveDocument.Paragraphs.Count
  If Selection.Characters(1).InRange(ActiveDocument.Paragraphs(i).Range) Then
    ParagraphIndex = i
    Exit For
  End If
Next I
MsgBox ParagraphIndex
Thunghi đã viết:
Hiển thị kết quả tìm thấy ... vào 1 file word khác.
Bạn khai một biến String ở General, vd Dim ZZZ As String
Trước khi
.Execute Replace:=wdReplaceAll
Bạn cho biến String nầy ghi các yêu cầu, vd:
ZZZ = ZZZ & Selection.Information(wdActiveEndPageNumber) & vbCrLf

Vì biến ZZZ là biến toàn cục, bạn có thể từ Sub nào đó lệnh ghi vào cuối document hay mở Document mới.

====
Bạn đọc thêm:
VBA MS Word
viewtopic.php?f=41&t=20042#p112424
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Thứ 6 21/09/2012 4:11 pm

Cám ơn anh TruongPhu rất nhiều, mới làm quen VBA cho word nên chưa hiểu nhiều, gần như không biết.
E đang làm 1 sub để tìm những ký tự sau dấu chấm mà không viết hoa thì liệt kê ra trang số và dòng số nhưng chưa biết gán số trang vào dòng cụ thể thế nào. Nhờ anh giúp.
MÃ: CHỌN TẤT CẢ

Sub HOASauCham()
Dim sTxt$, rTxt$
Dim i&, iDong&, sotrang&
Dim doan As Paragraph
For Each doan In ActiveDocument.Paragraphs
  iDong = iDong + 1
  sotrang = Selection.Information(wdActiveEndPageNumber)
  With Selection.Find
    .ClearFormatting
    .Text = ". [a-z]"
    .Forward = True
    .Wrap = wdFindContinue
    .Format = True
    .MatchCase = False
    .MatchWholeWord = False
    .MatchWildcards = True
    .MatchSoundsLike = False
    .MatchAllWordForms = False
    .Execute
    If .Found Then
      rTxt = rTxt & ";" & sotrang & ";" & iDong
    End If
  End With
  rTxt = rTxt & Chr(10)
Next doan
MsgBox rTxt
End Sub
Hình như thành viên mới chưa cho kèm file nên tạm copy đoạn văn nhỏ vào đây.
1.6 Tiêu chí 6: Hiệu trưởng. và công tác quản lý. hoạt động giáo dục.
1.7 Tiêu chí 7: Chế độ thông tin. ta báo cáo
1.8 Tiêu chí 8: Công tác bồi dưỡng chuyên môn nghiệp vụ và lý
luận chính trị.
2. Tiêu chuẩn x : Cán bộ quản lý. giáo viên và nhân viên
2.1 Tiêu chí 1: Cán bộ quản lý. giáo dục.
2.2 Tiêu chí 2: Giáo viên.
Kết quả như sau:
- Trang 1 dòng 1 sai (. v) phần sai cái gì thì kg cần lấy.
- Trang 1 dòng 2 sai (. t)
...
Xin cám ơn Anh.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 6 21/09/2012 5:21 pm

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Dim KQ$
 
Private Sub CommandButton1_Click()
    Selection.HomeKey Unit=wdStory
    HOASauChâm
    Documents.Add DocumentType=wdNewBlankDocument
    Selection.InsertAfter KQ
    Selection.Collapse wdCollapseEnd
End Sub
 
Sub HOASauChâm()
    With Selection.Find
        .ClearFormatting
        .Text = ". [a-z]"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Execute
        While .Found
            Selection.Range.Case = wdUpperCase
            KQ = KQ & "Page " & Selection.Information(wdActiveEndPageNumber) & ", "
            KQ = KQ & "Paragraph " & ParaNum & vbCrLf
            Selection.Collapse Direction=wdCollapseEnd
            .Execute
        Wend
    End With
End Sub
 
Function ParaNum() As Long
For I = 1 To ActiveDocument.Paragraphs.Count
   If Selection.Characters(1).InRange(ActiveDocument.Paragraphs(I).Range) Then
      ParagraphIndex = I
      Exit For
   End If
Next I
ParaNum = ParagraphIndex
End Function
GeSHi © Codebox Plus Extension


MS Word 2003:
TẬP TIN ĐÍNH KÈM
1.rar
(10.69 KiB) Đã tải về 291 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Thứ 6 21/09/2012 10:17 pm

E rất cám ơn anh, e đã vận dụng và làm thử 1 code tìm 2 khoảng trắng giữa 2 ký tự. E đang tìm hiểu các câu lệnh sau, trước mắt là thay thế và run thử đã.
Code của em
MÃ: CHỌN TẤT CẢ

Dim i&
Dim KQ$
Private Sub CommandButton1_Click()
    Selection.HomeKey Unit:=wdStory
    TwoBlank
    If Len(KQ) Then
        Documents.Add DocumentType:=wdNewBlankDocument
        Selection.InsertAfter KQ
        Selection.Collapse wdCollapseEnd
    End If
End Sub
Sub TwoBlank()
KQ = ""
    With Selection.Find
        .ClearFormatting
        .Text = Space(2)
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Execute
        While .Found
            KQ = KQ & "Page: " & Selection.Information(wdActiveEndPageNumber) & ", "
            KQ = KQ & "Paragraph: " & ParaNum & vbCrLf
            Selection.Collapse Direction:=wdCollapseEnd
            .Execute
        Wend
    End With
End Sub
Function ParaNum() As Long
For i = 1 To ActiveDocument.Paragraphs.Count
   If Selection.Characters(1).InRange(ActiveDocument.Paragraphs(i).Range) Then
      ParagraphIndex = i
      Exit For
   End If
Next i
ParaNum = ParagraphIndex
End Function
Câu sau là cho con trỏ về cuối, trường hợp e muốn về cuối và thêm 1 hàng nữa (ie Enter) thì sẽ làm thế nào.
MÃ: CHỌN TẤT CẢ

Selection.Collapse wdCollapseEnd
Một lần nữa cám ơn anh. Anh hd giúp để e vận dụng sang cái khác nữa. Còn nhiều cái cần học hỏi Anh.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 7 22/09/2012 10:06 am

Thunghi đã viết:
làm thử 1 code tìm 2 khoảng trắng giữa 2 ký tự.
code của bạn mới tìm 2 space
chưa có code thay
Selection.Find.Replacement.Text = " "
Thunghi đã viết:
trường hợp e muốn về cuối và thêm 1 hàng nữa (ie Enter) thì sẽ làm thế nào.
* Nếu di chuyển con trỏ, vẫn giữ nguyên bài viết, ta dùng MoveRight
Selection.MoveRight unit:=wdSentence, Count:=1, Extend:=wdMove
Bạn có thể thay đổi wdSentence với wdParagraph hay wdLine xem hằng nào thích hợp

* Nếu từ đó muốn gõ Enter xuống 1 dòng:
Selection.TypeParagraph
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Thứ 7 22/09/2012 10:54 am

Anh rất nhiệt tình, cám ơn Anh nhiều.
Cho e hỏi thêm vấn đề này.
1/ E muốn tìm lỗi sai sau dấu "." và "," thì phải có khoảng trắng và e áp dụng sau
sTxt=".[a-z]" thì OK với chữ thường nhưng chữ hoa thì phải thêm sTxt=".[A-Z]"
Có cách gì dồn 2 biến trên hay phải làm riêng biệt.
2/ E muốn tìm trong văn bản có ký tự nào không thuộc font Times New Romans, e đã record Macro Ctr F thì kg thấy đoạn nào chỉ ra font.
Nhờ anh giúp, cám ơn anh.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 7 22/09/2012 1:39 pm

Thunghi đã viết:
1/ E muốn tìm lỗi sai sau dấu "." và "," thì phải có khoảng trắng và e áp dụng sau
sTxt=".[a-z]" thì OK với chữ thường nhưng chữ hoa thì phải thêm sTxt=".[A-Z]"
Có cách gì dồn 2 biến trên hay phải làm riêng biệt.
sTxt=".[a-zA-Z]"
Thunghi đã viết:
2/ E muốn tìm trong văn bản có ký tự nào không thuộc font Times New Romans, e đã record Macro Ctr F thì kg thấy đoạn nào chỉ ra font.
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Function LiêtKêFont() As String
    For j = 1 To ActiveDocument.Paragraphs.Count
        For i = 1 To ActiveDocument.Paragraphs(j).Range.Characters.Count
            sFontType = ActiveDocument.Paragraphs(j).Range.Characters(i).Font.Name
            If InStr(1, sMsg, sFontType) = 0 Then
                sMsg = sMsg & "paragraph " & j & " character " & i & " " & sFontType & vbNewLine
            End If
        Next
    Next
    LiêtKêFont = sMsg
    'MsgBox sMsg 'truongphu
End Function
GeSHi © Codebox Plus Extension


Bạn có thể sửa lại code trên từ function thành Sub: vd:
sFontType = ActiveDocument.Paragraphs(j).Range.Characters(i).Font.Name
MÃ: CHỌN TẤT CẢ

if sFontType <> "Times New Romans" then
msgbox  "paragraph: " & j & " character: " & i & " " & sFontType
end if
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 7 22/09/2012 3:22 pm

truongphu đã viết:
sTxt=".[a-zA-Z]"
Nếu ta muốn gom luôn: vừa tìm chấm hay phẩy, kề theo là ký tự thường hay hoa, ta viết:
"([.,])([a-zA-Z])"

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
    With Selection.Find
        .MatchWildcards = True
        .Text = "([.,])([a-zA-Z])"
        .Replacement.Text = "\1 \2"
        .Execute Replace=wdReplaceAll
    End With
GeSHi © Codebox Plus Extension


.Text = "([.,])([a-zA-Z])" là chuỗi có 2 nhóm ký tự
nhóm 1 có 1 ký tự hoặc chấm hoặc phẩy
nhóm 2 có 1 ký tự hoặc thường hoặc hoa
Ghi chú: bao bọc các nhóm với ()

.Replacement.Text = "\1 \2"
vì .MatchWildcards = True nên VBE hiểu quy ước:
\1 là thế ký tự nhóm 1 tìm được
\2 là thế ký tự nhóm 2 tìm được
"\1 \2" chú ý ở giữa có space
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viênxuanha
Guru
Guru
Bài viết: 1230
Ngày tham gia: Thứ 5 19/08/2010 4:25 pm
Đến từ: Ban Tổ chức Thành uỷ Hưng Yên, tỉnh Hưng Yên
Has thanked: 13 times
Been thanked: 374 times
Tiếp xúc: Liên hệ xuanha
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by xuanha » Thứ 7 22/09/2012 8:48 pm

TruongPhu đã viết:
Sub HOASauChâm()
.Text = ". [a-z]"
-
-
While .Found
Selection.Range.Case = wdUpperCase
Selection.Collapse Direction:=wdCollapseEnd
-
-
End Sub
Với đoạn code trên thì các ký tự từ a-z sẽ được đổi thành chữ hoa.
Nhưng có một số chữ tiếng việt như: ắ, ặ, ằ .... ử, ữ .. thì không đổi thành chữ hoa.
Có lẽ đây cũng là vướng mắc mà nhiều người gặp phải nhưng chưa giải quyết được. Kính mong bác TruongPhu giúp đỡ.
Kiểm phiếu Đại hội Đoàn, Đại hội Đảng
http://caulacbovb.com/forum/viewtopic.php?t=23599
Đầu trang
207 bài viết      4   …  
Quay về
Trang chủDiễn đànThời gian được tính theo giờ UTC+07:00 UTC+7Xoá cookie của websiteLiên hệ chúng tôi
Đã tích hợp phpBB® Forum Software © phpBB Limited

Vietnamese language pack for phpBB 3.2.x download and support.

PRIVACY_LINK | TERMS_LINK

Page 5


Câu lạc bộ Visual Basic
.:: Nơi trao đổi về ngôn ngữ Visual Basic ::.

Bỏ qua nội dung

Nhập từ khóa tìm kiếm…
Đường dẫn nhanhTrợ giúpĐăng nhập
Trang chủDiễn đànTHẮC MẮC - TRAO ĐỔI - THẢO LUẬNVisual Basic for Application (VBA)
Trao đổi về Word VBA Mời vào đây!
Điều hành viên: tungblt

Nội quy chuyên mục

Tìm kiếm trong chủ đề này…
207 bài viết    …   5   …  
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 7 22/09/2012 9:19 pm

xuanha đã viết:
Nhưng có một số chữ tiếng việt như: ắ, ặ, ằ .... ử, ữ .. thì không đổi thành chữ hoa.
Có lẽ đây cũng là vướng mắc mà nhiều người gặp phải nhưng chưa giải quyết được.
.Text = ". ?"

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub HOASauChâm()
    With Selection.Find
        .ClearFormatting
        .Text = ". ?"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Execute
        While .Found
            Selection.Range.Case = wdUpperCase
            Selection.Collapse Direction=wdCollapseEnd
            .Execute
        Wend
    End With
End Sub
GeSHi © Codebox Plus Extension
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viênxuanha
Guru
Guru
Bài viết: 1230
Ngày tham gia: Thứ 5 19/08/2010 4:25 pm
Đến từ: Ban Tổ chức Thành uỷ Hưng Yên, tỉnh Hưng Yên
Has thanked: 13 times
Been thanked: 374 times
Tiếp xúc: Liên hệ xuanha
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by xuanha » Thứ 7 22/09/2012 10:20 pm

Em đã thử nhưng vẫn chưa thành công, bác xem có cách khác không?
Kiểm phiếu Đại hội Đoàn, Đại hội Đảng
http://caulacbovb.com/forum/viewtopic.php?t=23599
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Chủ nhật 23/09/2012 12:16 pm

E muốn gán các KQ sang 1 array.
Cụ thể như sau
MÃ: CHỌN TẤT CẢ

If sFontType <> "Times New Roman" Then
        .Characters(i).HighlightColorIndex = wdYellow
        tmpStr = "Câu: " & j & " Ký t" & ChrW(7921) & ": " & i & " " & sFontType
        iR = iR + 1
        ReDim Preserve Arr(1 To iR)
        Arr(iR) = Trim(tmpStr)
        tmpStr = ""
      End If
Và gán xuống là
MÃ: CHỌN TẤT CẢ

myStr = Join(Arr(), vbCrLf)
  Documents.Add DocumentType:=wdNewBlankDocument
  Selection.InsertAfter myStr
  Selection.Collapse wdCollapseEnd
  Erase Arr
Vậy có cách gì gán thẳng không cần biến MyStr?
Cám ơn Bác.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Chủ nhật 23/09/2012 3:23 pm

xuanha đã viết:
Em đã thử nhưng vẫn chưa thành công, bác xem có cách khác không?
Đúng rồi, tôi không để ý.
Nó chỉ có tác dụng với ký tự unicode không dấu thanh như â, ô...

Còn trường hợp có dấu thanh thì:
- Khi tìm được; đưa con trỏ về đầu nhóm tìm
- move qua 2 ký tự (chấm và space)
- bôi đen ký tự thứ 3 (unicode có dấu) và ucase nó

code như sau:

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub HOASauChâm()
    With Selection.Find
        .ClearFormatting
        .Text = ". ?"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        .Execute
        While .Found
            Selection.Collapse Direction=wdCollapseStart
            Selection.MoveRight unit=wdCharacter, Count=2, Extend=wdMove
            Selection.MoveRight unit=wdCharacter, Count=1, Extend=wdExtend
            Selection.Text = UCase(Selection.Text)
            Selection.Collapse Direction=wdCollapseEnd
            .Execute
        Wend
    End With
End Sub
GeSHi © Codebox Plus Extension


Thế là xong, tôi đã test kỹ trên MS Word 2003
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Chủ nhật 23/09/2012 3:27 pm

Thunghi đã viết:
E muốn gán các KQ sang 1 array.
Thunghi đã viết:
tmpStr = "Câu: " & j & " Ký t" & ChrW(7921) & ": " & i & " " & sFontType
        iR = iR + 1
        ReDim Preserve Arr(1 To iR)
        Arr(iR) = Trim(tmpStr)
Thunghi đã viết:
Và gán xuống là
myStr = Join(Arr(), vbCrLf)
Thunghi đã viết:
Vậy có cách gì gán thẳng không cần biến MyStr?
Do bạn tự làm rối chính mình

Tại sao bạn không viết chỉ một câu:
MÃ: CHỌN TẤT CẢ

tmpStr = tmpStr & "Câu: " & j & " Ký t" & ChrW(7921) & ": " & i & " " & sFontType & vbCrLf
:-t
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Thứ 2 24/09/2012 8:39 am

MÃ: CHỌN TẤT CẢ

tmpStr = tmpStr & "Câu: " & j & " Ký t" & ChrW(7921) & ": " & i & " " & sFontType & vbCrLf
E nghĩ rằng 1 chuỗi String nếu lớn quá sẽ ảnh hưởng nên muốn gán sang 1 array và gán lại. Chắc là do thói quen. Với lại e muốn vận dụng array vào.
Anh giúp e 1 ví dụ demo như sau:
Mở file A chạy code cho file B, tìm cái gì đó. Kết quả trả về trên file A. Đóng file B.
VBA Excel thì e có làm rồi nhưng word thì chưa rành về Doc nào active.
Cám ơn Anh.

E mới mày mò ra code mở folder, sửa lại từ VBA Ex.
MÃ: CHỌN TẤT CẢ

Sub GetPath()
Set sDoc = ThisDocument
sDoc.Activate
myPath = sDoc.Path
End Sub
Sub OpenFolder()
'mo file
GetPath
With Application.FileDialog(msoFileDialogOpen)
  .InitialFileName = myPath
  .AllowMultiSelect = False
  .Filters.Clear
  .Filters.Add "Excel files", "*.doc"
  .Show
  If .SelectedItems.Count = 0 Then
      MsgBox "Ban khong chon file"
      iChon = 0
      GoTo Next_Sub
  End If
  wName = .SelectedItems(1)
End With
Documents.Open wName
Set TgtDoc = ActiveDocument
Next_Sub:
End Sub
E dùng code trên thì cũng OK nhưng kg biết có phù hợp với VBA word?
Còn vấn đề này cần hỏi anh.
Nếu mình muốn tìm sau chấm là chữ Hoa nhưng lại đụng Unicode, và dùng .?, như thế thì nhựng ký tự sau "1.1" nó cũng hiểu luôn, làm sao loại trừ số.
Trong Find của word nếu muốn tìm
.Text = ChrW(7842) (Ả)
Or
.Text =ChrW(272) (Đ)
Or
... thì dùng cách gì.
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Thứ 2 24/09/2012 11:54 am

MÃ: CHỌN TẤT CẢ

While .Found
             Selection.Collapse Direction:=wdCollapseStart
             Selection.MoveRight unit:=wdCharacter, Count:=2, Extend:=wdMove
             Selection.MoveRight unit:=wdCharacter, Count:=1, Extend:=wdExtend
             Selection.Text = UCase(Selection.Text)
             Selection.Collapse Direction:=wdCollapseEnd
             .Execute
         Wend
E vận dụng code sau để tìm những ký tự không viết hoa sau chấm, nhưng không sửa thành chữ hoa mà chỉ tô màu vàng.
MÃ: CHỌN TẤT CẢ

While .Found
    Selection.Collapse Direction:=wdCollapseStart
    Selection.MoveRight unit:=wdCharacter, Count:=2, Extend:=wdMove
    Selection.MoveRight unit:=wdCharacter, Count:=1, Extend:=wdExtend
    If Not UCase(Selection.Text) Then
      Selection.Range.HighlightColorIndex = wdYellow
    End If
    Selection.Collapse Direction:=wdCollapseEnd
    .Execute
  Wend
Nhưng thắc mắc câu lệnh gì để kiểm tra có phải là Upper
MÃ: CHỌN TẤT CẢ

If Not UCase(Selection.Text) Then
Nhờ anh hướng dẫn giúp.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 2 24/09/2012 12:03 pm

Thunghi đã viết:
chuỗi String nếu lớn quá sẽ ảnh hưởng
String chỉ ì ạch khi đến mức 1 MB
Thunghi đã viết:
Sub GetPath()
Set sDoc = ThisDocument
sDoc.Activate
myPath = sDoc.Path
End Sub
sao không viết:
MÃ: CHỌN TẤT CẢ

myPath = ThisDocument.Path
Thunghi đã viết:
  .AllowMultiSelect = False
  .Filters.Clear
2 câu nầy không cần, vì mặc định khi mở đã như thế.
Thunghi đã viết:
Documents.Open wName
Set TgtDoc = ActiveDocument
Viết:
MÃ: CHỌN TẤT CẢ

Set TgtDoc = Documents.Open wName
Thunghi đã viết:
E dùng code trên thì cũng OK nhưng kg biết có phù hợp với VBA word?
Đương nhiên OK, ý bạn đang dùng code trên ở đâu?
Nếu dùng trên VB6 sẽ báo lỗi, vd Documents.Open, VB6 đâu biết Documents là gì, chỉ có trên VBA Word nó mới hiểu nhanh.
Thunghi đã viết:
Nếu mình muốn tìm sau chấm là chữ Hoa nhưng lại đụng Unicode, và dùng .?, như thế thì nhựng ký tự sau "1.1" nó cũng hiểu luôn, làm sao loại trừ số.
Loại trừ để làm gì? Ucace của ký tự 1 cũng là 1
Thunghi đã viết:
Trong Find của word nếu muốn tìm
.Text = ChrW(7842) (Ả)
Or
.Text =ChrW(272) (Đ)
Or
... thì dùng cách gì.
thì dùng dấu ?
Hoặc thông qua một TextBox MS Form 2.0 hổ trợ unicode
MÃ: CHỌN TẤT CẢ

TextBox1.Text = ChrW(7842)
.Text = TextBox1.Text
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 2 24/09/2012 12:22 pm

Thunghi đã viết:
Nhưng thắc mắc câu lệnh gì để kiểm tra có phải là Upper
thì cứ cho nó Ucase luôn, kiểm tra làm gì? Ucase("A") sẽ trả về "A"

để kiểm tra có phải là Upper
MÃ: CHỌN TẤT CẢ

MsgBox Selection.Range.Case
0 là thường, 1 là Hoa
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Thứ 2 24/09/2012 1:24 pm

E đang làm 1 code kiểm tra chính tả cụ thể là Hoa sau chấm, no blank trước chấm ... nên chỉ cần liệt kê và tô màu thôi.
Trường hợp e ở 1 file excel và mở file word thao tác. Sáu đó gán kết quả ở file excel thì vận dụng code trên có OK. Anh tư vấn giúp.
Cám ơn Anh rất nhiều. Anh ở Cam Đức, Khánh Hòa có phải là nơi có nhiều xoài? E cũng ở Nha Trang trước đó. Học THPT Lý Tự Trọng. Có thể xem là đồng hương nhỉ?

Cho e hỏi thêm, muốn kết hợp
sTxt = "([ ])([.,/{}+:;])"
Nhưng e muốn tìm thêm blank trước dấu ! hay dấu [ thì dùng thế nào.
Còn vd sau
"Tôi buồn!Bạn thì sao ?"
Sau dấu ! phải có blank
Trước dấu ? không có blank.
Em chưa vận dụng được.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 2 24/09/2012 3:10 pm

Thunghi đã viết:
E đang làm 1 code kiểm tra chính tả
bạn là giáo viên hả?
Thunghi đã viết:
nên chỉ cần liệt kê và tô màu thôi.
Sau đây là project kiểm tra không space sau chấm hay phẩy, chỉ tô màu vàng
Word A tác Ðông Word B.rar
(13.3 KiB) Đã tải về 334 lần
Thunghi đã viết:
Cho e hỏi thêm, muốn kết hợp
sTxt = "([ ])([.,/{}+:;])"
chỉ chọn một trong những ký tự, ta đưa vàp dấu []
vd: [.,+-:;] là tìm 1 ký tự được liệt kê trong ngoặc vuông
Thunghi đã viết:
Nhưng e muốn tìm thêm blank trước dấu ! hay dấu [ thì dùng thế nào.
space thì nhấn space bình thường
dấu ! và dấu [ thì có thêm \ ví dụ: \! hay \[
Thunghi đã viết:
"Tôi buồn!Bạn thì sao ?"
Sau dấu ! phải có blank
Trước dấu ? không có blank.
Em chưa vận dụng được.
1-
.Text = "([\!])([! ^13])"
có 2 nhóm: nhóm 1 là tìm 1 ký tự !
nhóm 2 là tìm 1 ký tự không phải space và không phải xuống dòng (vì đã xuống dòng thì viết đúng)
! không có dấu \ ở trước nghĩa là không có vd !a là ký tự khác a, có dấu \! là tìm !

2-
.text = " \?"
space gạch xuống và hỏi
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Thứ 2 24/09/2012 4:10 pm

Cám ơn Anh rất nhiều.
Khi nào tiện anh giải thích thêm về .MatchWildcards. Phần Find mà kết hợp .MatchWildcards thì rất hay.
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Thứ 3 25/09/2012 9:07 am

E có code như sau để tìm TwoBlank của 1 file, nhưng kg biết code sai chỗ nào mà tìm file # 10 pages thì OK nhưng còn file # 100 pages thì quá lâu và không biết nó còn chạy?.
Anh xem giúp em code có sai gì.
MÃ: CHỌN TẤT CẢ

'''***Copy a Truong Phu - Caulacbovb.com
Dim i&, iR&
Dim myPath$, wName$
Dim sDoc As Document
Dim TgtDoc As Document
Dim sTxt$, myStr$, tmpStr$
Dim Arr()
Dim isWildcards As Boolean
Code chính tìm 2 blank
MÃ: CHỌN TẤT CẢ

Sub TwoBlank()
With Application
  .ScreenUpdating = False
End With
XoaToMau
sTxt = Space(2)
isWildcards = True
CommandAll (sTxt)
MakeReport
With Application
  .ScreenUpdating = True
End With
End Sub
Code phụ
MÃ: CHỌN TẤT CẢ

Public Sub XoaToMau()
OpenFolder
TgtDoc.Select
Selection.WholeStory
Selection.Range.HighlightColorIndex = wdNoHighlight
Selection.HomeKey unit:=wdStory
End Sub
Public Sub CommandAll(StrFi As String)
iR = 0
With Selection.Find
  .ClearFormatting
  .Text = StrFi
  .Forward = True
  .Wrap = wdFindContinue
  .Format = True
  .MatchCase = False
  .MatchWholeWord = False
  If isWildcards Then
    .MatchWildcards = True
  Else
    .MatchWildcards = False
  End If
  .MatchSoundsLike = False
  .MatchAllWordForms = False
  .Execute
  While .Found
    Selection.Range.HighlightColorIndex = wdYellow
    tmpStr = "Page: " & Selection.Information(wdActiveEndPageNumber) & ", "
    tmpStr = tmpStr & "Paragraph: " & ParaNum
    Selection.Collapse Direction:=wdCollapseEnd
    iR = iR + 1
    ReDim Preserve Arr(1 To iR)
    Arr(iR) = Trim(tmpStr)
    tmpStr = ""
    .Execute
  Wend
End With
End Sub
Public Sub MakeReport()
sDoc.Select
If iR Then
  myStr = Trim(Join(Arr(), vbCrLf))
  'Selection.Collapse wdCollapseEnd
  With Selection
    .EndKey unit:=wdStory 'Dua con tro ve cuoi
    .TypeParagraph 'Enter
    .TypeParagraph 'Enter
    .InsertAfter myStr 'Gan MyStr
    .Collapse wdCollapseEnd
  End With
  Erase Arr
End If
Set sDoc = Nothing
Set TgtDoc = Nothing
End Sub
Function ParaNum() As Long
For i = 1 To ActiveDocument.Paragraphs.Count
  If Selection.Characters(1).InRange(ActiveDocument.Paragraphs(i).Range) Then
     ParagraphIndex = i
     Exit For
  End If
Next i
ParaNum = ParagraphIndex
End Function
Sub GetPath()
Set sDoc = ThisDocument
myPath = ThisDocument.Path
End Sub
Sub OpenFolder()
'mo file
GetPath
With Application.FileDialog(msoFileDialogOpen)
  .InitialFileName = myPath
  .AllowMultiSelect = False
'  .Filters.Clear
  .Filters.Add "Word files", "*.doc"
  .Show
  If .SelectedItems.Count = 0 Then
      MsgBox "Ban khong chon file"
      GoTo Next_Sub
  End If
  wName = .SelectedItems(1)
End With
Documents.Open wName
Set TgtDoc = ActiveDocument
Next_Sub:
End Sub
E chưa được quyền gởi file nên nhờ anh lấy đại 1 file nào đó test giúp.
Hướng của e là làm 1 vòng lặp duyệt qua mỗi lần 10 trang để chạy. Nhưng không biết thuật toán select find cho từng trang.
Cám ơn Anh nhiều.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 3 25/09/2012 4:21 pm

Thunghi đã viết:
E chưa được quyền gởi file nên nhờ anh lấy đại 1 file nào đó test giúp.
untitled.JPG
untitled.JPG (23.54 KiB) Đã xem 9716 lần
Thunghi đã viết:
nhưng kg biết code sai chỗ nào mà tìm file # 10 pages thì OK nhưng còn file # 100 pages thì quá lâu và không biết nó còn chạy?.
Đã chạy được thì chỗ nào cũng OK
Thunghi đã viết:
Nhưng không biết thuật toán select find cho từng trang.
Cám ơn Anh nhiều.
Bạn đã có code mô tả trang mà selection đang hiện diện.
Có thể đặt điều kiện với nó

Ví dụ tìm mỗi 10 trang:
MÃ: CHỌN TẤT CẢ

Dim I&
If Selection.Information(wdActiveEndPageNumber) Mod 10 = 0 then
i = i + 1
MsgBox i
End If
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Thứ 3 25/09/2012 5:50 pm

Cám ơn Anh nhiều.
E nghĩ code chậm là chỗ này, nó cứ tìm từ 1 lại, để e cải tiến tìm từ iPos xem.
MÃ: CHỌN TẤT CẢ

Function ParaNum() As Long
For i = 1 To ActiveDocument.Paragraphs.Count
  If Selection.Characters(1).InRange(ActiveDocument.Paragraphs(i).Range) Then
     ParagraphIndex = i
     Exit For
  End If
Next i
ParaNum = ParagraphIndex
End Function
...
iPos=Paranum
...
MÃ: CHỌN TẤT CẢ

For i = iPos To ActiveDocument.Paragraphs.Count
Em tạm thế câu sau thì OK.
MÃ: CHỌN TẤT CẢ

tmpStr = "Page: " & Selection.Information(wdActiveEndPageNumber) & ", "
    tmpStr = tmpStr & "dong" & Selection.Information(wdFirstCharacterLineNumber)
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Câu đố Word: Replace giữ nguyên Format
Gửi bài by truongphu » Thứ 4 03/10/2012 9:27 am

Ví dụ ta có nội dung như hình sau:
1.JPG
1.JPG (18.95 KiB) Đã xem 9663 lần
Yêu cầu thay thế từ Rstuvw bằng từ Abcdef, với yêu cầu giữ nguyên định dạng của từ cũ.
kết quả yêu cầu là:
2.JPG
2.JPG (19.63 KiB) Đã xem 9663 lần
Tình huống nầy ta cũng hay gặp, thậm chí có bạn đã đặt câu hỏi...
Mời các bạn tham gia code Replace thao điều kiện trên
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Thunghi
Thành viên chính thức
Thành viên chính thức
Bài viết: 16
Ngày tham gia: Thứ 5 20/09/2012 2:42 pm
Has thanked: 40 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Thunghi » Thứ 5 04/10/2012 8:31 pm

Yêu cầu thay thế từ Rstuvw bằng từ Abcdef, với yêu cầu giữ nguyên định dạng của từ cũ.
kết quả yêu cầu là:
Em vận dụng record macro va những điều học từ Anh Phú và viết thử code sau.
Anh xem giúp em. Cám ơn Anh!
MÃ: CHỌN TẤT CẢ

Sub FindReplace()
Dim sTxt$, rTxt$
Dim i&
sTxt = "Rstuvw"
rTxt = "Abcdef"
With Selection
  .HomeKey Unit:=wdStory
  .Find.ClearFormatting
End With
With Selection.Find
  .Text = sTxt
  .Forward = True
  .Wrap = wdFindContinue
  .Format = False
  .MatchCase = False
  .MatchWholeWord = False
  .MatchWildcards = False
  .MatchSoundsLike = False
  .MatchAllWordForms = False
  .Execute
  While .Found
    'Selection.MoveLeft Unit:=wdWord, Count:=1'
    Selection.Collapse Direction:=wdCollapseStart
    For i = 1 To Len(sTxt)
      Selection.MoveRight Unit:=wdCharacter, Count:=1, Extend:=wdExtend
      Selection.Text = Mid(rTxt, i, 1)
      Selection.MoveRight Unit:=wdCharacter, Count:=1
    Next i
    .Execute
  Wend
End With
End Sub
Sửa lần cuối bởi 1 vào ngày Thunghi với 0 lần sửa trong tổng số.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 5 04/10/2012 8:44 pm

Thunghi đã viết:
Em vận dụng record macro va những điều học từ Anh Phú và viết thử code sau.
Anh xem giúp em.
Bạn "nhuyễn" quá!
Không ý kiến gì thêm.

Đấy là kinh nghiệm để giữ y nguyên định dạng.

nếu thay ngay "Rstuvw" bằng "Abcdef", chỉ giữ được định dạng ký tự đầu CHUNG cho cả từ "Abcdef"

=D>

======
Thunghi đã viết:
  While .Found
    Selection.MoveLeft Unit:=wdWord, Count:=1
    For i = 1 To Len(sTxt)
      Selection.MoveRight Unit:=wdCharacter, Count:=1, Extend:=wdExtend
      Selection.Text = Mid(rTxt, i, 1)
      Selection.MoveRight Unit:=wdCharacter, Count:=1
    Next i
    .Execute
  Wend
Đáp án:
While .Found
Selection.Collapse Direction:=wdCollapseStart
For i = 1 To 6
Selection.MoveRight Unit:=wdCharacter, Count:=1, Extend:=wdExtend
Selection.Text = Mid(zzz, i, 1)
Selection.Collapse Direction:=wdCollapseEnd
Next
.Execute
Wend
:) >:D<
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
thangcola113
Bài viết: 1
Ngày tham gia: Thứ 6 07/12/2012 10:09 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by thangcola113 » Thứ 3 11/12/2012 11:16 am

Thắc mắc trong tạo mục lục cho word???
Trong phần tạo mục lục, Với cụm từ:
Chương I (Xuống dòng bằng phím Enter)
Phần mở đâù
///
Giúp em Viết macro: tìm và thay thế phần xuống dòng trên bằng phím Shift+Enter
Giả thiết là tìm các từ Chương "I -XV" và chỉ thay thế trong dòng của từ này. Kết quả sẽ thu được sau khi chạy macro là:
Chương I (Xuống dòng bằng phím Shift+Enter)
Phần mở đâù
Đầu trang
kieuphongVB
Bài viết: 1
Ngày tham gia: Thứ 3 29/01/2013 1:15 pm
Re: Thân gửi anh Trượng Phu. HELP!
Gửi bài by kieuphongVB » Thứ 3 29/01/2013 1:25 pm

Một hôm bướt chân về gác nhỏ
Chợt nhớ đóa hoa Tường Vy.
… …

CSDL
bướt chân
bước chân


Phần không có trong file
- tôi có chèn 1 Bookmark ngay trước dòng CSDL

Xin trợ giúp toàn thể khán giả.
Vì sao đoạn code dưới (find and Replace) không tìm được từ “bướt chân” trong đoạn nhạc trên ???
HELP, HELP…

Đoạn code như sau:

Sub Macro4()
'
' Macro4 Macro
' Macro recorded 1/29/2013 by Smart
'
Dim tuCanThay, tuThayThe As String

Selection.GoTo What:=wdGoToBookmark, Name:="CSDL"
Selection.MoveDown Unit:=wdLine, Count:=1
Selection.EndKey Unit:=wdLine, Extend:=wdExtend
tuCanThay = Selection
MsgBox (tuCanThay)
Selection.HomeKey Unit:=wdLine
Selection.MoveDown Unit:=wdLine, Count:=1
Selection.EndKey Unit:=wdLine, Extend:=wdExtend
tuThayThe = Selection
MsgBox (tuThayThe)
Selection.HomeKey Unit:=wdLine

Selection.HomeKey Unit:=wdStory
Selection.Find.ClearFormatting
Selection.Find.Replacement.ClearFormatting
With Selection.Find
.Text = tuCanThay
.Replacement.Text = tuThayThe
End With
If Selection.Find.Execute = True Then
MsgBox ("tim thay " & tuCanThay)
Else
MsgBox ("ko tim thay " & tuCanThay)
End If
Selection.Find.Execute Replace:=wdReplaceAll


End Sub
Đầu trang
207 bài viết    …   5   …  
Quay về
Trang chủDiễn đànThời gian được tính theo giờ UTC+07:00 UTC+7Xoá cookie của websiteLiên hệ chúng tôi
Đã tích hợp phpBB® Forum Software © phpBB Limited

Vietnamese language pack for phpBB 3.2.x download and support.

PRIVACY_LINK | TERMS_LINK


Page 6


Câu lạc bộ Visual Basic
.:: Nơi trao đổi về ngôn ngữ Visual Basic ::.

Bỏ qua nội dung

Nhập từ khóa tìm kiếm…
Đường dẫn nhanhTrợ giúpĐăng nhập
Trang chủDiễn đànTHẮC MẮC - TRAO ĐỔI - THẢO LUẬNVisual Basic for Application (VBA)
Trao đổi về Word VBA Mời vào đây!
Điều hành viên: tungblt

Nội quy chuyên mục

Tìm kiếm trong chủ đề này…
207 bài viết    …   6   …  
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Replace All và vấn đề chiếm dụng RAM
Gửi bài by truongphu » Thứ 6 08/03/2013 3:18 pm

Replace All và vấn đề chiếm dụng RAM

Trong các macro của Word (VBA), ứng dụng tìm và thay thế (Find and Replace) có nhiều ví dụ trong chủ đề nầy; mà câu lệnh thông thường là:
Selection.Find.Execute Replace:=wdReplaceAll
Bạn sẽ thấy một điều là bộ nhớ (RAM) nhanh chóng tụt thấp nếu dùng nhiều lần lệnh trên. Mà lệnh (code) là để mà dùng chứ không lẽ để ngắm?

Thông thường để edit một file doc khoảng 20 MB, dùng các lệnh Replace:=wdReplaceAll khoảng vài chục lần thì RAM khoảng 500 MB tự do dần dần tiêu thụ hết, Windows sau đó phải đẩy dữ liệu ra page.sys để giải phóng RAM, việc nầy khiến máy trở nên trì trệ

Trước đây để tránh việc nầy, mỗi lần RAM còn chừng 100 MB tôi lưu file và thoát Word, sau đó chạy lại; đương nhiên RAM sau khi Word.Close sẽ phục hồi, máy vẫn linh động. Tuy nhiên vẫn cảm giác "không sướng"!

Sở dĩ File dung lượng nhỏ nhiều so bộ nhớ, nhưng khi hoạt động .Execute Replace:=wdReplaceAll, lượng RAM nhanh chóng tiêu hao gấp nhiều lần vì Word tự động tạo ra trong RAM mỗi bản sao file doc đã được replace, số bản sao cứ tăng lên theo lệnh khiến cho RAM giảm nhanh chóng. Việc nầy chỉ chấm dứt khi ta hạ lệnh save và thoát Word. Động tác Save mà không thoát vẫn không giải phóng RAM vì Word vẫn giữ các bản sao cho Undo.

Mặt lợi của việc làm trên là thời gian xử lý nhanh chóng. Với máy mạnh (đa nhân đa luồng), vài GB RAM và file doc nhỏ vài chục MB, .Execute Replace:=wdReplaceAll là "vô tư"! Tuy nhiên với các biên tập viên có "hoàn cảnh" thao tác với chiếc PC "bèo" thì việc RAM tụt xuống zero quả là khó chịu. Nhanh đâu không thấy, chỉ làm việc mươi phút, máy đã ì ạch...

Sau đây là ví dụ một macro thông dụng, tìm "chúng ta" và thay với "các anh"
MÃ: CHỌN TẤT CẢ

Sub Macro1()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "chúng ta"
        .Replacement.Text = "các anh"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
End Sub
Mặc dù code trên có vẻ dài thòng, nhưng tất cả chỉ là khai báo một lần trong cấu trúc With... End With
Như đã nói, việc hao tốn RAM chỉ là câu lệnh cuối:
Selection.Find.Execute Replace:=wdReplaceAll

Chấp nhận việc xử lý lâu một tí, bù lại RAM không giảm bao nhiêu (để duy trì máy linh hoạt), chúng ta đành từ bỏ câu lệnh
.Execute Replace:=wdReplaceAll
và dùng Sub TìmThayNgay thế cho câu lệnh trên:
MÃ: CHỌN TẤT CẢ

Sub TìmThayNgay()
Dim ZZZZ As Range
    Do While Selection.Find.Execute _
        (Replace:=wdReplaceNone, Forward:=True) = True
        Set ZZZZ = ActiveDocument.Range _
            (Start:=Selection.Start, End:=Selection.End)
        ZZZZ = Selection.Find.Replacement.Text
        Selection.MoveRight wdWord, 1, wdMove
    Loop
End Sub
Code trong Sub trên là một vòng lặp để tìm và thay Do... Loop
* Dòng 3 và 4 nối liền nghĩa là mỗi lần tìm có
* Dòng 5 và 6 nối liền và dòng 7 nghĩa là thay ngay trên file word giùm tôi
* Dòng 8 nghĩa là Con trỏ (Selection) dịch qua 1 chữ để tìm tiếp

Tôi bảo đảm với bạn nào có PC yếu cần biên tập trên MS Word dùng VBA, máy sẽ chạy êm, có điều: chậm một tí!

Code sửa toàn văn cho bạn nào chưa quen:

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub Macro2()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "chúng ta"
        .Replacement.Text = "các anh"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    TìmThayNgay
End Sub
 
Sub TìmThayNgay()
Dim ZZZZ As Range
    Do While Selection.Find.Execute _
        (Replace=wdReplaceNone, Forward=True) = True
        Set ZZZZ = ActiveDocument.Range _
            (Start=Selection.Start, End=Selection.End)
        ZZZZ = Selection.Find.Replacement.Text
        Selection.MoveRight wdWord, 1, wdMove
    Loop
End Sub
GeSHi © Codebox Plus Extension


Hay khong ? B-)

Chúc mừng các em gái trong forum nhân 8/3 @};-
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Chủ nhật 10/03/2013 8:46 pm

Viết lại Sub TìmThayNgay vì thấy rườm rà...

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub TìmThayNgay()
 With Selection.Find
    .Execute Replace=wdReplaceOne
    While .Found
        .Execute Replace=wdReplaceOne
    Wend
 End With
End Sub
GeSHi © Codebox Plus Extension


;;)
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
hungtiensinh
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 2 06/05/2013 10:49 pm
Has thanked: 3 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by hungtiensinh » Thứ 2 06/05/2013 11:44 pm

Nhờ các bác giúp đỡ
Tôi có các file, trong file có nhiều dòng, nhiều đoạn và nhiều trang nằm lẫn lộn giữa chữ và công thức chủ yếu chứa các phương trình phản ứng :
CaCl2+Na2CO3 --> CaCO3 + 2NaCl hoặc 1s2 2s2 2p6 3s1
..........................
Tôi muốn viết 1 đoạn code để các chữ màu đỏ xuống dưới và các chữ màu xanh lên trên.
Ý tưởng : cho vòng lặp chạy từ đầu đến cuối và có 2 biến xy. Nếu x là chữ và y là số thì định dạng y là chỉ số dưới. Nếu x là các chữ s,p,d,f và y là số thì sẽ định dạng y chỉ số trên.

Ý tưởng là vậy nhưng không thể viết code được !
Mong các bác giúp, chân thành cảm ơn !
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 4 08/05/2013 5:16 pm

hungtiensinh đã viết:
hungtiensinh
gớm! chắc anh bạn nầy lớn tuổi nhỉ!
hungtiensinh đã viết:
có 2 biến xy
Dim X As String * 1, Y As String * 1
Đưa con trỏ về đầu bài
Selection.HomeKey Unit:=wdStory, Extend:=wdMove
hungtiensinh đã viết:
cho vòng lặp chạy từ đầu đến cuối
Do Until Selection.Range.Bookmarks.Exists("\EndOfDoc") = True
'...
Loop

Trong vòng lặp, cho con trỏ lần lượt chọn 2 ký tự:
Selection.MoveRight Unit:=wdCharacter, Count:=2, Extend:=wdExtend
2 ký tự nầy phân phối cho 2 biến:
X = Left(Selection.Text, 1): Y = Right(Selection.Text, 1)
hungtiensinh đã viết:
Nếu x là chữ và y là số thì định dạng y là chỉ số dưới. Nếu x là các chữ s,p,d,f và y là số thì sẽ định dạng y chỉ số trên.
* Nếu X là chữ và Y là số thì:
If (Not IsNumeric(X)) And (IsNumeric(Y)) Then
* Chọn bôi đen ký tự sau, và cho fontsize nhỏ lại:
Selection.Collapse Direction:=wdCollapseEnd
Selection.MoveLeft Unit:=wdCharacter, Count:=1, Extend:=wdExtend
Selection.Font.Size = 6
* Xem xét chữ gì:

Select Case X
Case "s", "p", "d", "f"
Selection.Font.Superscript = wdToggle 'nâng cao
Case " "
Case Else
Selection.Font.Subscript = wdToggle ' ha thâp
End Select

Code toàn vẹn và chạy êm như sau;
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub Macro1()
    Dim X As String * 1, Y As String * 1
    Selection.HomeKey Unit=wdStory, Extend=wdMove
   
    Do Until Selection.Range.Bookmarks.Exists("\EndOfDoc") = True
    Selection.MoveRight Unit=wdCharacter, Count=2, Extend=wdExtend
    X = Left(Selection.Text, 1) Y = Right(Selection.Text, 1)
    If (Not IsNumeric(X)) And (IsNumeric(Y)) Then
            Selection.Collapse Direction=wdCollapseEnd
            Selection.MoveLeft Unit=wdCharacter, Count=1, Extend=wdExtend
            Selection.Font.Size = 6
        Select Case X
            Case "s", "p", "d", "f"
            Selection.Font.Superscript = wdToggle
            Case " "
            Case Else
            Selection.Font.Subscript = wdToggle
        End Select
    Selection.Collapse Direction=wdCollapseEnd
    Else
    Selection.Collapse Direction=wdCollapseStart
    Selection.MoveRight Unit=wdCharacter, Count=1, Extend=wdMove
    End If
    Loop
End Sub
GeSHi © Codebox Plus Extension


Rõ ràng với code trên, các con số chỉ giới hạn 1 ký tự

Doc 2003:
TẬP TIN ĐÍNH KÈM
Phản ứng hóa học.rar
(7.49 KiB) Đã tải về 357 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
hungtiensinh
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 2 06/05/2013 10:49 pm
Has thanked: 3 times
`
Gửi bài by hungtiensinh » Thứ 6 10/05/2013 11:54 pm

Rất cảm ơn bài viết kèm theo lời giải thích chu đáo của bác o0o--truongphu--o0o

Đúng là như vầy : 1s2 2s2 2p6 3s2
Nhưng nó bị như vầy :1s2 2s2 2p6 3s2

các chữ màu đỏ phải nằm ngang hàng với chữ s,p,d,f nhưng nó bị hạ xuống !
Khi ghé thăm bác chỉnh lại đôi chút nhé!
Chân thành cám ơn !

(Đây là file : http://www.mediafire.com/view/?n99v6xdq8a88r4o)

? Hoi thêm bác o0o--truongphu--o0o, nếu như mình viết bằng VB6 để sử dụng cho nhiều file, chứ không phải mỗi file đều phải chép macro để chạy, như vậy cần thiết thay câu lệnh nào trong đó.
(Về VB6 tôi cũng biết tí tí, xíu xíu về cách tạo form)
file : http://www.mediafire.com/?zzzz852sztxlql8

Thông tin thêm về nick hungtiensinh " Tâm hồn tuổi trẻ, sở thích của người già, tuổi gần trung niên"
Tôi là GV dạy Hóa đôi lúc trong giờ dạy hay lòng ghép kể chuyện ,.. để giảm bớt tính khô khan của môn học , riết rồi học trò nói giống ông già nên gọi là tiên sinh, chứ tuổi chưa có già, hihi!
Đầu trang
wan
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 2 17/10/2011 10:51 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by wan » Thứ 6 17/05/2013 9:14 am

Hi Mr TruongPhu.

E có 1 câu hỏi sau đây muốn nhờ a giúp đỡ. Câu hỏi như sau ạ:
-Vd e có 1 file doc là nội dung của phần phụ lục pdf với 200 trang. Trong file doc có chương 1 là từ trang 1-70; 2 từ 71-150; 3 từ 151-200. Nội dung của file này như sau:
"Chuong 1 1
Hoi 1 2
Hoi 2 15
Hoi 3 35
Hoi 4 64
Chuong 2 71
Hoi 1 72
Hoi 2 120
Chuong 3 151
Hoi 1 152
Hoi 2 170"

*Với file phụ lục trên e muốn chèn 1 số thẻ ở trong các số trang của phụ lục. VD:

"Chuong 1 <a href="01_Chuong.html#ch1">1</a>
Hoi 1 <a href="01_Chuong.html#Hoi1">2</a>
Hoi 2 <a href="01_Chuong.html#Hoi2">15</a>
Hoi 3 <a href="01_Chuong.html#Hoi3">35</a>
Hoi 4 64
Chuong 2 71
Hoi 1 72
Hoi 2 120
Chuong 3 151
Hoi 1 152
Hoi 2 170"

E định thay thế trong word bằng wildcards các số rồi chèn thẻ trước, sau nhưng trong wildcards khi search nó không giới hạn số cần tìm rồi chỉ thay thế số đó. E muốn thay các chỉ các trang từ 1 tới 70 thôi nhưng search wildcards nó tìm rộng quá không giới hạn dc. A có biết cách nào giới hạn số cần tìm trong wildcards chỉ giúp e với.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 6 17/05/2013 12:50 pm

wan đã viết:
"Chuong 1 1
Có một em mê truyện!
wan đã viết:
nhưng trong wildcards khi search nó không giới hạn số cần tìm rồi chỉ thay thế số đó. E muốn thay các chỉ các trang từ 1 tới 70 thôi nhưng search wildcards nó tìm rộng quá không giới hạn dc.
Nghĩa là bạn đã viết được 2 mẫu Selection.Find.Text và Selection.Find.Replacement.Text
Trong tìm và thay, 2 điều trên là khó nhất...
wan đã viết:
cách nào giới hạn số cần tìm trong wildcards chỉ giúp e với.
Thay vì bạn viết
Selection.Find.Execute Replace:=wdReplaceAll
chúng sẽ thay thế toàn bộ...

Ở đây, bạn muốn giới hạn trong 70 trang đầu. Con số nầy sẽ được nhận biết từ Selection.Find.Text, vd:
Hoi 2 15
Ta chỉ việc cho một biến để nhận giá trị nầy là xong!
MÃ: CHỌN TẤT CẢ

Dim ZZZZ As Range, MM() As String
        Do While Selection.Find.Execute _
        (Replace:=wdReplaceNone, Forward:=True) = True
            Set ZZZZ = ActiveDocument.Range _
            (Start:=Selection.Start, End:=Selection.End)
            MM = Split(ZZZZ.Text)
            If Int(MM(2)) > 70 then
              Exit Do
            else
             Selection.Find.Execute  Replace:=wdReplaceOne  
            end if  
        Loop
dòng 1: khai 2 biến: ZZZZ là Range để tiếp thu Selection.Find.Text và mảng String MM()
dòng 2: Chỉ cho tìm mà không thay
dòng 3: Khi tìm được thì: Cho biến ZZZZ nhận đối tượng đã tìm được
dòng 4: biến MM cắt Selection.Find.Text
dòng 5: so sánh phần tử MM(2) xem lớn hơn 70 không
Lớn hơn thì thoát
Nhỏ hơn thì chỉ thay 1 lần
Vòng lặp tiếp tục...

Kỹ thuật trên là kỹ thuật đọc được Selection.Find.Text khi nó biến đổi (wildcards)
Có nhiều bài viết tương tự trong chủ đề nầy, bạn đọc lại xem...
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
wan
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 2 17/10/2011 10:51 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by wan » Thứ 2 20/05/2013 9:44 pm

Vâng. Để e ngâm cứu thêm. Có vấn đề nào khó hiểu xin dc a chỉ giáo thêm. E cảm ơn anh nhé.
Đầu trang
wan
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 2 17/10/2011 10:51 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by wan » Thứ 3 21/05/2013 3:45 pm

MÃ: CHỌN TẤT CẢ

Sub ThayTheTrongXML()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "([A-z]{2,100}) ([0-9]{1,5})"
        .Replacement.Text = "\1 <b>\2</b>"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = True
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    ThayThe
End Sub
Sub ThayThe()
Dim ZZZZ As Range, MM() As String
        Do While Selection.Find.Execute _
        (Replace:=wdReplaceNone, Forward:=True) = True
            Set ZZZZ = ActiveDocument.Range _
            (Start:=Selection.Start, End:=Selection.End)
            MM = Split(ZZZZ.Text)
            If Int(MM(2)) > 70 Then
              Exit Do
            Else
             Selection.Find.Execute Replace:=wdReplaceOne
            End If
        Loop

End Sub
A xem giúp e code bên trên, khi e chạy báo "out of range". A có thể giải thích giúm e kỹ hơn ở phần "Sub ThayThe()" dc không. Dim ZZZ as range có tác dụng gì, as string là biến gì, và khi nào sử dụng nó dc không. Set ZZZ .... có tác dụng như thế nào??? E xin cảm ơn ạ
Đầu trang
hungtiensinh
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 2 06/05/2013 10:49 pm
Has thanked: 3 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by hungtiensinh » Thứ 4 19/06/2013 9:59 am

Chào anh chị em !
Tôi muốn viết một code (trong Word 2003) : textbox hoặc đối tượng shapes tự động di chuyển đến trang có chứa con trỏ. VD con trỏ ở trang 1 thì textbox trang 1. Nếu di chuyển con trỏ xuống trang 2 thì textbox di chuyển theo !
Anh chi em nào đã nghiên cứu hoặc có ý tưởng xin giúp dùm !
Chân thành cảm ơn !
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 4 19/06/2013 6:10 pm

hungtiensinh đã viết:
Nếu di chuyển con trỏ xuống trang 2 thì textbox di chuyển theo !
Khác với Excel: có sự kiện Worksheet_SelectionChange(ByVal Target As Range)
[Giải thích thêm: con trỏ ở excel luôn luôn xác định vùng ít nhất là 1 cell, cũng gọi là Selection]
Và vì Excel có sự kiện Worksheet_SelectionChange nên có thể thêm code kèm theo sự kiện nầy.

Trái lại, Word không có sự kiện SelectionChange hay tương đương,
do đó RẤT KHÓ VIẾT SỰ KIỆN MỖI KHI CON TRỎ THAY ĐỔI (SelectionChange)
[Nghĩa là thay đổi ngay lập tức khi con trỏ thay đổi]

Muốn, bạn phải:
1- Viết một sub riêng để đưa textbox về vị trí con trỏ hiện hành (selection)
Đương nhiên để chạy sub nầy phải qua 1 commandbutton hay phím tắt.
2- Để biến công việc hoàn toàn tự động: textbox theo con trỏ ngay lập tức; bạn phải:
- Chế tạo một Timer như VB6 (VBA không có control nầy)
- Code của Timer nầy: Bạn so sánh Selection.Text, nghĩa là mỗi lần con trỏ di chuyển, bạn ghi nhớ selection.text vào 1 biến string, sau đó cứ so sánh, Nếu giống thì thôi, nếu khác, chạy Sub đã viết ở mục 1
hungtiensinh đã viết:
có ý tưởng xin giúp dùm !
Tôi chỉ giúp bạn cách làm; tiên liệu việc làm khá rối vì bạn phải vững về tạo các control VB6
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
caotrung
Bài viết: 3
Ngày tham gia: Chủ nhật 20/05/2012 9:39 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by caotrung » Thứ 5 20/06/2013 12:42 pm

Chào các anh.
Em có một vặn bản word trong đó đã dùng chế độ xuống dòng và đặt kí tự tự động, ví dụ như:
A. aaaaaaaaaaaaaaa
B. bbbbbbbbbbbbbbb
C. ccccccccccccccc
D. ddddddddddddddd
E. eeeeeeeeeeeeeeee
................
Nghĩa là khi hết ý A và ấn enter thì văn bản tự động xuống dòng và điền B...............
Trong văn bản đã định dạng sẵn như vậy ở rất nhiều chỗ.
Bây giờ em muốn chuyển thành
A. aaaaaaaaaaaaaaa
B. bbbbbbbbbbbbbbb
C. ccccccccccccccc
D. ddddddddddddddd
E. eeeeeeeeeeeeeeee
nhưng phải bỏ được định dạng xuống dòng tự động.
Từ trước tới giờ em toàn làm việc đó thủ công. Tức là sửa từng ý một.
Vậy nhờ các anh trong diễn đàn viết giúp em một code macro để có thể sửa đồng loạt được không ạ.
Em chân thành cảm ơn các bác.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 4 10/07/2013 9:23 pm

caotrung đã viết:
ấn enter thì văn bản tự động xuống dòng và điền B...............
File Word của bạn đã có macro
Bạn vào Visual Basic Editor, tìm và vô hiệu nó là xong
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 4 10/07/2013 9:33 pm

Nguyen Van Cau đã viết:
Mình có xem một số bài viết của anh trên trang web câu lạc bộ vb, có thấy nhiều lần anh trả lời ngắn gọn và hay quá, nên tính nhờ anh giúp cho viết cho 1 cái macro như sau, và xin gửi anh một ít chi phí gọi là để có quỹ uống cà phê cà pháo, quy ra đô là 5 hay 6 USD cho mỗi lần nhờ; nếu anh không phiền hà gì. Không biết như vậy là có thỏa đáng cho anh không, hay anh có ý kiến gì thì cứ cho biết, mình chưa quen. Thấy anh hay giải các bài toán như trang web, cũng có thể nhờ trên đó, nhưng vào Chuyện Linh Tinh của anh lại thấy địa chỉ email nên thử gửi; có ý muốn gửi thêm 1 tý bột cà phê ấy mà.
....
nó như thế này:
Mình có cái file word, muốn là : đặt con trỏ vào 1 từ nào đó/hoặc bôi đen cũng được. [thí dụ ở đây con trỏ nằm vào trong từ to ] . Sau đó bấm vào macro mà anh viết, nó sẽ :


1/ tạo ra 1 file .txt do người dùng đặt tên cho mỗi lần tạo và lưu vào đâu đó; file đó có chứa thông tin này:

- ghi từ to này với 3 từ khác trước và sau nó; và giảm dần đến 1 từ ở trước và sau; theo dạng sau [ví dụ] cho tất cả văn bản, và liệt kê hết ra.
trainer was able to communicate complex ideas
was able to communicate complex
able to communicate
TESTAMENTS to our QUALITY SERVICES
TESTAMENTS to our QUALITY
TESTAMENTS to our
any organisation looking to sharpen their negotiation
- - - - - - to - - - -
.....vv...


mặc định là con số 3 như thế, dĩ nhiên số này có thể thay đổi bằng mã VBA; hoặc đưa ra được lựa chọn thì quá tốt rồi (nhưng nếu vất vả cho anh thì bỏ qua)

để ý là các từ "to" xếp thẳng hàng với nhau.
các dấu đơn độc cũng kể như một từ, thí dụ viết sai chính tả thành to , and to ,
thì dấu , cũng được kể là một từ. Còn dấu nào đứng sát từ khác thì kể là thuộc về từ đó.

thí dụ các từ nào mà có dấu , liền kề thì cũng kể luôn dấu ấy thuộc từ đó cho nhanh như cụm từ này : , professional, , professional/lalala,
thì chọn luôn từ professional,
professional/lalala,
để sắp xếp.

(tất nhiên file .txt không bôi gì cả, anh biết đấy)
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub LàmTùyÝTheoYêuCâu()
' Tìm vi trí desktop trên máy bât ky (test trên HÐH WindowsXP / MS Word 2003)
Dim DuongdanDesktop$
Set objshell = CreateObject("Shell.Application").Namespace(0)
DuongdanDesktop = objshell.Self.Path & ""
Dim NgàyGio$ NgàyGio = Format(Now, "ddmmyyyy-hhnn")
Set objshell = CreateObject("Scripting.FileSystemObject").OpenTextFile(DuongdanDesktop & NgàyGio & ".txt", 8, 1, -1)
 
' Yêu câu phai bôi Ðen tu Ðã chon
   Dim jj%, sôtu% sôtu = 3
    Dim dòng$, Tìm$ Tìm = Selection.Text
    With Selection.Find
        .Text = Tìm
    Do While Selection.Find.Execute _
        (Replace=wdReplaceNone, Forward=True) = True
 
        For jj = sôtu To 1 Step -1
        dòng = String(sôtu - jj, vbTab)
        Selection.Collapse Direction=wdCollapseStart
        ' Kiêm tra ky không dính
       Selection.MoveLeft wdCharacter, 1, wdExtend
        If Selection.Text <> " " Then
            Exit For
        Else
            Selection.Collapse Direction=wdCollapseEnd
        End If
       
        Selection.MoveLeft wdWord, jj, wdExtend
        dòng = dòng & Selection.Text
        Selection.Collapse Direction=wdCollapseEnd
        Selection.MoveRight wdWord, 1, wdExtend
 
        If Selection.Text <> Tìm Then Exit For
 
        dòng = dòng & Tìm
 
        Selection.Collapse Direction=wdCollapseEnd
        Selection.MoveRight wdWord, jj, wdExtend
        dòng = dòng & Selection.Text
 
        Selection.Collapse Direction=wdCollapseStart
        Selection.MoveLeft wdWord, 1, wdExtend
 
        If Selection.Text <> Tìm Then Exit For
       
        objshell.Write dòng & vbCrLf
        dòng = ""
        Next
        objshell.Write "- - - - - -" & vbCrLf
        Selection.MoveRight wdWord, 1, wdMove
    Loop
   End With
objshell.Close
MsgBox "Ðã xong"
End Sub
GeSHi © Codebox Plus Extension


Trong code trên, tôi đặt rất nhiều bẫy lỗi vì việc selection.move khá rối

===
Với bạn có lòng như: >:D<
có ý muốn gửi thêm 1 tý bột cà phê ấy mà.
TRUONG PHU
TK: 0581000543799
NGAN HANG NGOAI THUONG VIETCOMBANK
Phòng GD Cam Duc Cam lam Khanh Hoa

Nên chuyên qua ATM để phí chuyển nhẹ =D>
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Unicode tổ hợp và Unicode dựng sẵn
Gửi bài by truongphu » Thứ 2 15/07/2013 8:04 am

Trong các văn bản (word document, text), tiếng Việt unicode có thể biểu hiện lẫn lộn giữa unicode dựng sẵn và unicode tổ hợp; nếu nhìn bằng mắt thường rất khó phân biệt.

Ta xét thí dụ dãy ký tự có dấu đơn giản sau:
á à ả ã ạ
mỗi ký tự ta thấy, độ dài của chúng là 1 ký tự, có mã code là:
225 224 7843 227 7841
đấy là mã unicode quen thuộc: unicode dựng sẵn.

Nhưng chuỗi y chang sau:
á à ả ã ạ
thì mỗi ký tự gồm 2 ký tự gộp lại = độ dài là 2 ký tự;
mà ký tự đầu là ký tự a có mã code là 97
và ký tự sau sẽ có mã code theo thứ tự là 769 768 777 771 và 803
Trường hợp nầy lại là unicode tổ hợp.

Khi viết ứng dụng, nếu chúng ta dùng các lệnh có liên quan độ dài chuỗi như Len, Left, Mid, Right, kết quả có thể không như ý. nếu các lệnh nầy nằm trong vòng lặp, khi gặp điều kiện tương ứng, có thể dẫn đến vòng lặp vô hạn = treo máy!

Hoặc khi dùng sub Find and Replace, kết quả không toàn vẹn: vẫn còn chuỗi trong văn bản không đáp ứng.

Do đó để việc làm được êm xuôi, tốt nhất ta hãy thay các ký tự unicode tổ hợp sang unicode dựng sẵn. Vì văn bản chứa lẫn lộn 2 loại ký tự nên ta không thể chọn hết để chuyễn mã, mà phải dùng chức năng Find and Replace.
Bạn đọc có thể dùng vòng lặp, kết hợp hàm Mid để thay từng ký tự trong toàn văn bản. Tôi cung cấp 2 chuỗi dính liền sau:

Đây là chuỗi unicode tổ hợp (mỗi ký tự có Len = 2)
áàảãạắằẳẵặấầẩẫậéèẻẽẹếềểễệíìỉĩịóòỏõọốồổỗộớờởỡợúùủũụứừửữựýỳỷỹỵ

và đây là unicode dựng sẵn quen thuộc:
áàảãạắằẳẵặấầẩẫậéèẻẽẹếềểễệíìỉĩịóòỏõọốồổỗộớờởỡợúùủũụứừửữựýỳỷỹỵ

Hay không?
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
hungtiensinh
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 2 06/05/2013 10:49 pm
Has thanked: 3 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by hungtiensinh » Thứ 4 07/08/2013 9:02 pm

Trong Word mình tô đen 1 đoạn văn bản, rồi xác định có bao nhiêu chữ a hoặc số 10 thì code VBA của word viết sau. ạ
(http://www.caulacbovb.com/forum/viewtop ... 15&t=21600) coi tới lui các bài viết nhưng trình độ yếu nên chưa biết cách làm !
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 5 08/08/2013 9:24 am

hungtiensinh đã viết:
tô đen 1 đoạn văn bản, rồi xác định có bao nhiêu chữ a hoặc số 10
1- lý thuyết:
Giải thuật đếm số ký tự trong chuỗi

2- Code:
http://truongphu111.blogspot.com/2012/0 ... uoi-1.html
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
tieulongnu_young
Thành viên chính thức
Thành viên chính thức
Bài viết: 12
Ngày tham gia: Thứ 4 18/08/2010 3:58 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by tieulongnu_young » Thứ 6 20/09/2013 11:33 am

Chào mọi người,

em có môt vấn đề cần mọi người giúp đỡ. Em đang làm một template trong word, tạo CV cho các chuyên gia của công ty. Trong mỗi template có một placeholder để chèn hình ảnh. Song song với template đó là một danh sách thông tin các chuyên gia dùng để mail merge (trộn thư). Tuy nhiên, em đang bó tay vì không tự động trộn thư cả hình ảnh luôn, mà phải chèn hình ảnh thủ công sau khi hoàn tất công tác trộn thư. Và nếu danh sách chuyên gia này lên đến 500 người thì có nghĩa là em phải làm đến 500 thao tác chèn hình. Có ai biết chỉ giúp em code này với, có thể trộn thư với cả hình ảnh luôn không ạ? Em cám ơn rất nhiều.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 6 20/09/2013 2:23 pm

tieulongnu_young đã viết:
một danh sách thông tin
Bạn nên dùng Access để làm csdl hơn là dùng Excel
tieulongnu_young đã viết:
để mail merge (trộn thư)
Đương nhiên công việc nầy giao cho VBA làm. Word có hướng dẫn chức năng nầy: Menu Tools\ Letters and Mailing\ Mail Merge...
tieulongnu_young đã viết:
em đang bó tay vì không tự động trộn thư cả hình ảnh luôn, mà phải chèn hình ảnh thủ công sau khi hoàn tất công tác trộn thư.
Đó là do bạn dùng csdl Excel.
Nếu bạn dùng Access, trong file mdb, các dòng thông tin trên các cột đều chuyển tải khi mail merge, kể cả cột hình!

Để đưa hình vào access, bạn dùng ADODB.Stream. Chi tiết, bạn xem thêm ở
95- Kỹ thuật ghi hình vào file MDB và load hình từ MDB ra Picture1

hoặc load project
Nhâp Anh và Load Anh.rar

Chúc bạn thành công
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
tieulongnu_young
Thành viên chính thức
Thành viên chính thức
Bài viết: 12
Ngày tham gia: Thứ 4 18/08/2010 3:58 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by tieulongnu_young » Thứ 6 20/09/2013 4:52 pm

Em cám ơn anh Trường Phú rất nhiều. Tuy nhiên, em nhờ anh làm rõ giúp em một tí:
- Theo như anh nói, em sẽ tạo một danh sách dùng để trộn thư bằng access, trong đó có trường hình ảnh, phải không ạ?
- Sau đó, trong access, em vào Alt_F11 để mở cửa sổ VBA lên, copy code dưới đây
' Load hình anh vào MDB
Anh.LoadFromFile ("D:\MY DOCUMENTS\My Pictures\vet1.jpg")
Rec.Fields("hinhanh").Value = Anh.Read
Rec.Update

Tuy nhiên em không rõ thao tác để đưa code này vào là làm như thế nào? Anh vui lòng chỉ chi tiết giúp em được không ạ?
Với tên trường là hinhanh thì các bản ghi em nên ghi như thế nào để chèn hình cho đúng? Các file hình ảnh em nên đưa vào một thư mục nhưng nên đặt tên file như thế nào?

Anh vui lòng chỉ giáo giúp em nhé! Cám ơn anh rất nhiều./.
Đầu trang
207 bài viết    …   6   …  
Quay về
Trang chủDiễn đànThời gian được tính theo giờ UTC+07:00 UTC+7Xoá cookie của websiteLiên hệ chúng tôi
Đã tích hợp phpBB® Forum Software © phpBB Limited

Vietnamese language pack for phpBB 3.2.x download and support.

PRIVACY_LINK | TERMS_LINK

Page 7


Câu lạc bộ Visual Basic
.:: Nơi trao đổi về ngôn ngữ Visual Basic ::.

Bỏ qua nội dung

Nhập từ khóa tìm kiếm…
Đường dẫn nhanhTrợ giúpĐăng nhập
Trang chủDiễn đànTHẮC MẮC - TRAO ĐỔI - THẢO LUẬNVisual Basic for Application (VBA)
Trao đổi về Word VBA Mời vào đây!
Điều hành viên: tungblt

Nội quy chuyên mục

Tìm kiếm trong chủ đề này…
207 bài viết    …   7   …  
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 7 21/09/2013 6:59 pm

tieulongnu_young đã viết:
Theo như anh nói, em sẽ tạo một danh sách dùng để trộn thư bằng access, trong đó có trường hình ảnh, phải không ạ?
Tôi đã thử lại nhiều cách: có hay không có placehold, vẫn không thành công khi merge mail.
Thành thật xin lỗi cô tieulongnu_young

Để bù lại:

cách 1:
http://wordnut.hubpages.com/hub/IncludePicture

Nội dung trong trang web nầy: Insert 1 file ảnh: trước khi nhấn Insert, hãy nhấn nhẹ bên góc phải của nút và chọn Link to File

Các file hình để trong một folder, tên file trùng với dữ liệu của một field, ví dụ field DiaDiem
Hình chèn liên kết sẽ hiện lên. Nhấn Alt + F9 để chuyển qua chế độ code, sẽ thấy: vd
{ INCLUDEPICTURE "D:\\My Documents\\My Pictures\\Hinh Ve Tinh\\Nha Phu.BMP" \* MERGEFORMAT \d }

Trong câu trên, rõ ràng file Nha Phu.BMP đã được chọn, hãy thay Nha Phu với { MERGEFIELD "DiaDiem" }, sẽ thành:
{ INCLUDEPICTURE "D:\\My Documents\\My Pictures\\Hinh Ve Tinh\\{ MERGEFIELD "DiaDiem" }.BMP" \* MERGEFORMAT \d }

Nhấn lại Alt + F9 để trớ lại nhìn bình thường
các bước mail merge như cũ. Sau đó sẽ kiểm tra được (preview) hình có thay đổi hay không...
Xong nhớ xuất ra file

cách 2:
http://www.smallbusinesscomputing.com/b ... etters.htm

Thấy hướng dẫn trên Word 2003, Mục Select document type, chọn E-mail messagge thay vì Letters, nhưng chả hiểu sao Word trên máy tôi không có, có lẽ do không cài outlook...

cách 3: Tôi đã test êm:
office.microsoft.com/en-us/publisher-help/merge-pictures-into-a-publication-HP001038506.aspx

Nội dung là yêu cầu cài thêm Publisher. Tôi đã cài bổ sung Pub 2003 trong bộ O 2003
Trong nầy, khi gọi mail ra, chọn mail merge
Trong file CSDL, có field ghi path của hình ảnh, chỉ cần Path là đủ
Khi chèn Field nầy vào file, phải nhấn nhẹ nút bên phải để chọn chế độ bên dưới: Insert As Picture

và thế là OK.

Chúc cô nàng thành công.
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
tieulongnu_young
Thành viên chính thức
Thành viên chính thức
Bài viết: 12
Ngày tham gia: Thứ 4 18/08/2010 3:58 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by tieulongnu_young » Thứ 3 24/09/2013 4:28 pm

Cám ơn anh Trường Phú đã hướng dẫn tận tình, em đã làm theo cách 1 của anh và tham khảo thêm đương link anh gửi, nhưng không hiểu sao mọi bước em làm đều đúng nhưng hình ảnh vẫn không thay đổi đươc, em đã làm đúng theo từng chi tiết của hướng dẫn, nhờ anh tư vấn giúp em xem nên làm thế nào đây anh ơi./.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 4 25/09/2013 9:45 am

http://truongphu111.blogspot.com/2013/0 ... -mail.html
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
wan
Thành viên chính thức
Thành viên chính thức
Bài viết: 10
Ngày tham gia: Thứ 2 17/10/2011 10:51 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by wan » Thứ 5 10/10/2013 2:54 pm

A có thể giúp e tạo macro chuyển đổi font smallcap trong word được không. E có 1 từ có font small cap, vì font small cap nó Hoa lớn ở từ đầu tiên và nhỏ ở từ thứ 2 trở đi. Giờ e muốn chèn 1 thẻ cho các từ phía sau. VD chữ: HHHHH là font small cap. Giờ e muốn chèn như sau: H<sc>HHHH</sc>. A có thể tạo giúp e macro chuyển đổi như trên được không. E cám ơn!
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 7 12/10/2013 8:49 pm

wan đã viết:
giúp e tạo macro chuyển đổi font smallcap trong word được không
Chưa rõ bạn muốn đổi font gì
wan đã viết:
muốn chèn 1 thẻ cho các từ phía sau. VD chữ: HHHHH là font small cap. Giờ e muốn chèn như sau: H<sc>HHHH</sc>.
Đấy là tìm và thay thông thường. Các code tìm và thay ở các trang trước. Code tìm và thay không lệ thuộc kiểu font!
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
anhcau
Bài viết: 8
Ngày tham gia: Thứ 7 06/07/2013 1:18 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by anhcau » Thứ 2 21/10/2013 8:40 am

Lính mới đây!

Đóng góp bài sưu tầm tý cho xôm tụ; vì ngu dốt nên cứ dùng của người khác làm ra rồi đem ra giới thiệu cho ace. Thông cảm nhé.
Có cái bài tìm từ trong file word, xin giới thiệu. Ở đây nó sẽ tìm từ và đưa ra số lượng từ đó.
Có điều nó chỉ tìm được Tiếng Anh, còn dạng Unicode như TViet thì mình thấy nó tìm không được. Không hiểu có ai cải tiến được không?

Đây là lời giới thiệu
As you are analyzing your documents, you may wonder if there is a way to create a count of the number of words in the document. Unfortunately, Word doesn't include such a feature, but there are a couple of things you can do.

First, if you want to know the number of times a specific word or phrase is used, you can follow these steps:

Press Ctrl+H to display the Replace tab of the Find and Replace dialog box.

Figure 1. The Replace tab of the Find and Replace dialog box.
In the Find What box, enter the word or phrase you want counted.
In the Replace With box, enter ^&. This character sequence tells Word that you want to replace what you find with whatever you placed in the Find What box. (In other words, you are replacing the word or phrase with itself.)
If you are searching for individual words, make sure you click the Find Whole Words Only check box.
Click on Replace All. Word makes the replacements and shows you how many instances it replaced. That is the number you want.

This approach works great if you just have one or two words or phrases you want to know about. You can automate the process a bit by using a macro to search through the document and count for you. The following macro prompts the user for a word, and then counts the number of times that word appears in the document. It will continue to ask for another word until the user clicks on the Cancel button.

MÃ: CHỌN TẤT CẢ

Sub FindWords()
    Dim sResponse As String
    Dim iCount As Integer

    ' Input different words until the user clicks cancel
    Do
        ' Identify the word to count
        sResponse = InputBox( _
          Prompt:="What word do you want to count?", _
          Title:="Count Words", Default:="")
    
        If sResponse > "" Then
            ' Set the counter to zero for each loop
            iCount = 0
            Application.ScreenUpdating = False
            With Selection
                .HomeKey Unit:=wdStory
                With .Find
                    .ClearFormatting
                    .Text = sResponse
                    ' Loop until Word can no longer
                    ' find the search string and
                    ' count each instance
                    Do While .Execute
                        iCount = iCount + 1
                        Selection.MoveRight
                    Loop
                End With
                ' show the number of occurences
                MsgBox sResponse & " appears " & iCount & " times"
            End With
            Application.ScreenUpdating = True
        End If
    Loop While sResponse <> ""
End Sub
Đầu trang
anhcau
Bài viết: 8
Ngày tham gia: Thứ 7 06/07/2013 1:18 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by anhcau » Thứ 2 21/10/2013 8:48 am

[sưu tầm tiếp]
Còn đây là nó tìm từng từ một và thống kê số lượng từ. Rồi đưa ra 1 file word. Mình đã thử 1 lần và nó tìm được và đưa ra nhưng toàn là chữ thường thôi, chưa kiểm tra hết các trường hợp. Nó đưa ra được cả từ Unicode. Mời ace cần cải tiến hay tham khảo thì cứ tùy nghi.


If you want to determine all the unique words in a document, along with how many times each of them appears in the document, then a different approach is needed. The following VBA macro will do just that.
MÃ: CHỌN TẤT CẢ

Sub WordFrequency()
    Const maxwords = 9000          'Maximum unique words allowed
    Dim SingleWord As String       'Raw word pulled from doc
    Dim Words(maxwords) As String  'Array to hold unique words
    Dim Freq(maxwords) As Integer  'Frequency counter for unique words
    Dim WordNum As Integer         'Number of unique words
    Dim ByFreq As Boolean          'Flag for sorting order
    Dim ttlwds As Long             'Total words in the document
    Dim Excludes As String         'Words to be excluded
    Dim Found As Boolean           'Temporary flag
    Dim j, k, l, Temp As Integer   'Temporary variables
    Dim ans As String              'How user wants to sort results
    Dim tword As String            '

    ' Set up excluded words
    Excludes = "[the][a][of][is][to][for][by][be][and][are]"

    ' Find out how to sort
    ByFreq = True
    ans = InputBox("Sort by WORD or by FREQ?", "Sort order", "WORD")
    If ans = "" Then End
    If UCase(ans) = "WORD" Then
        ByFreq = False
    End If
    
    Selection.HomeKey Unit:=wdStory
    System.Cursor = wdCursorWait
    WordNum = 0
    ttlwds = ActiveDocument.Words.Count

    ' Control the repeat
    For Each aword In ActiveDocument.Words
        SingleWord = Trim(LCase(aword))
        'Out of range?
        If SingleWord < "a" Or SingleWord > "z" Then
            SingleWord = ""
        End If
        'On exclude list?
        If InStr(Excludes, "[" & SingleWord & "]") Then
            SingleWord = ""
        End If
        If Len(SingleWord) > 0 Then
            Found = False
            For j = 1 To WordNum
                If Words(j) = SingleWord Then
                    Freq(j) = Freq(j) + 1
                    Found = True
                    Exit For
                End If
            Next j
            If Not Found Then
                WordNum = WordNum + 1
                Words(WordNum) = SingleWord
                Freq(WordNum) = 1
            End If
            If WordNum > maxwords - 1 Then
                j = MsgBox("Too many words.", vbOKOnly)
                Exit For
            End If
        End If
        ttlwds = ttlwds - 1
        StatusBar = "Remaining: " & ttlwds & ", Unique: " & WordNum
    Next aword

    ' Now sort it into word order
    For j = 1 To WordNum - 1
        k = j
        For l = j + 1 To WordNum
            If (Not ByFreq And Words(l) < Words(k)) _
              Or (ByFreq And Freq(l) > Freq(k)) Then k = l
        Next l
        If k <> j Then
            tword = Words(j)
            Words(j) = Words(k)
            Words(k) = tword
            Temp = Freq(j)
            Freq(j) = Freq(k)
            Freq(k) = Temp
        End If
        StatusBar = "Sorting: " & WordNum - j
    Next j

    ' Now write out the results
    tmpName = ActiveDocument.AttachedTemplate.FullName
    Documents.Add Template:=tmpName, NewTemplate:=False
    Selection.ParagraphFormat.TabStops.ClearAll
    With Selection
        For j = 1 To WordNum
            .TypeText Text:=Trim(Str(Freq(j))) _
              & vbTab & Words(j) & vbCrLf
        Next j
    End With
    System.Cursor = wdCursorNormal
    j = MsgBox("There were " & Trim(Str(WordNum)) & _
      " different words ", vbOKOnly, "Finished")
End Sub

When you open a document and run this macro, you are asked if you want to create a list sorted by word or by frequency. If you choose word, then the resulting list is shown in alphabetical order. If you choose frequency, then the resulting list is in descending order based on how many times the word appeared in the document.

While the macro is running, the status bar indicates what is happening. Depending on the size of your document and the speed of your computer, the macro may take a while to complete. (I ran it with a 719-page document with over 349,000 words and it took about five minutes to complete.)

Note that there is a line in the macro that sets a value in the Excludes string. This string contains words that the macro will ignore when putting together the word list. If you want to add words to the exclusion list, simply add them to the string, between [square brackets]. Also, make sure the exclusion words are in lowercase.

If you don't like to use macros for some reason, there are other programs you can use to create word counts. For instance, the NoteTab text editor (the "light" version can be downloaded free at http://www.notetab.com) includes a feature that provides a word count. All you need to do is copy your entire document and paste it into NoteTab. Then, within NoteTab, choose Tools | Text Statistics | More. It presents an analysis of the word frequency, including percentages.
Đầu trang
anhcau
Bài viết: 8
Ngày tham gia: Thứ 7 06/07/2013 1:18 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by anhcau » Thứ 5 24/10/2013 2:23 pm

Tôi học hỏi của anh Phú được một số kỹ thuật xử lý cho word. Khá hữu ích, xin anh chị em phát triển thêm !!
Có một vấn đề này trong VBA code : Tên Hàm: Mở document, tự động đến trang lần trước đang đọc , nhưng nó sẽ bị nhảy lỗi khi phải tắt word bất thình lình, tức là nó không lưu lại được cái trang hiện có (thí dụ treo máy) thì làm thế nào để khắc phục là nó tự động nhảy về khi trước nhỉ, và làm sao nó tự động lưu trang đang xem, khi thoát ra mỗi lần nó không hỏi có lưu hay không (dù chỉ mở xem qua)
MÃ: CHỌN TẤT CẢ

' On Document_Close event procedure write below code
Private Sub Document_Close()
     Selection.Collapse Direction:=wdCollapseStart
     ActiveDocument.Bookmarks.Add Name:="LastPosition", Range:=Selection.Range
End Sub

'On Document_Open event procedure, write below code
Private Sub Document_Open()
    Selection.GoTo what:=wdGoToBookmark, Name:="LastPosition"
    ActiveDocument.Bookmarks("LastPosition").Delete
End Sub
Đầu trang
anhcau
Bài viết: 8
Ngày tham gia: Thứ 7 06/07/2013 1:18 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by anhcau » Thứ 3 29/10/2013 1:49 pm

Mới sưu tầm được món hiển thị các sheet trong exell như mã dưới đây. Làm sao có thể hiển thị được tương tự nếu dùng trong Word VBA. Xin các cao thủ chỉ giáo giúp

Thí dụ nó liệt kê các sheet1 / sheet2/ sheet3 để in




MÃ: CHỌN TẤT CẢ

Sub SelectSheets()
    Dim i As Integer
    Dim TopPos As Integer
    Dim SheetCount As Integer
    Dim PrintDlg As DialogSheet
    Dim CurrentSheet As Worksheet
    Dim cb As CheckBox
    Application.ScreenUpdating = False

'   Check for protected workbook
    If ActiveWorkbook.ProtectStructure Then
        MsgBox "Workbook is protected.", vbCritical
        Exit Sub
    End If

'   Add a temporary dialog sheet
    Set CurrentSheet = ActiveSheet
    Set PrintDlg = ActiveWorkbook.DialogSheets.Add

    SheetCount = 0

'   Add the checkboxes
    TopPos = 40
    For i = 1 To ActiveWorkbook.Worksheets.Count
        Set CurrentSheet = ActiveWorkbook.Worksheets(i)
'       Skip empty sheets and hidden sheets
        If Application.CountA(CurrentSheet.Cells) <> 0 And _
            CurrentSheet.Visible Then
            SheetCount = SheetCount + 1
            PrintDlg.CheckBoxes.Add 78, TopPos, 150, 16.5
                PrintDlg.CheckBoxes(SheetCount).Text = _
                    CurrentSheet.Name
            TopPos = TopPos + 13
        End If
    Next i

'   Move the OK and Cancel buttons
    PrintDlg.Buttons.Left = 240

'   Set dialog height, width, and caption
    With PrintDlg.DialogFrame
        .Height = Application.Max _
            (68, PrintDlg.DialogFrame.Top + TopPos - 34)
        .Width = 230
        .Caption = "Select sheets to print"
    End With

'   Change tab order of OK and Cancel buttons
'   so the 1st option button will have the focus
    PrintDlg.Buttons("Button 2").BringToFront
    PrintDlg.Buttons("Button 3").BringToFront

'   Display the dialog box
    CurrentSheet.Activate
    Application.ScreenUpdating = True
    If SheetCount <> 0 Then
        If PrintDlg.Show Then
            For Each cb In PrintDlg.CheckBoxes
                If cb.Value = xlOn Then
                    Worksheets(cb.Caption).Activate
                    ActiveSheet.PrintOut
'                   ActiveSheet.PrintPreview 'for debugging
                End If
            Next cb
        End If
    Else
        MsgBox "All worksheets are empty."
    End If

'   Delete temporary dialog sheet (without a warning)
    Application.DisplayAlerts = False
    PrintDlg.Delete

'   Reactivate original sheet
    CurrentSheet.Activate
End Sub
Đầu trang
tamsan
Bài viết: 1
Ngày tham gia: Thứ 2 18/11/2013 4:33 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by tamsan » Thứ 2 18/11/2013 4:40 pm

Mấy bác cao nhân giúp em với, số là em tạo 1 mẫu template sẵn trong Word bây giờ em muốn add nó vào theo 1 đường dẫn (C:\Documents and Settings\user name\Application Data\Microsoft\Templates.) viết bằng code VBA nha mấy bác chứ copy bằng tay thì em biết. Nhưng trước khi save hiện lên bảng thông báo" bạn có muốn save hay là không". cám ơn mấy bác. và cái macro nay em save thanh 1 file sao đó em add vào Add-Ins làm công cụ riêng nhưng ko biết đường dẫn vào Add-In vì e muốn đóng gói thành file exe cài tự động.
Đầu trang
minhvientiger
Bài viết: 2
Ngày tham gia: Thứ 6 20/12/2013 12:17 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by minhvientiger » Thứ 6 27/12/2013 12:11 pm

Các anh chị ơi! Có thể viết cho em đoạn mã cho commandButton trong powerpoint đang trình chiếu để mở một file powerpoint định dạng *.pps khác được không ạ? Với điều kiện file mở lên cũng ở dạng trình chiếu luôn. À! Sẳn cho thêm dòng code để khi mở file mới thì nó đóng file cũ luôn. Em cảm ơn nhiều lắm.
Đầu trang
moitinhdau
Thành viên chính thức
Thành viên chính thức
Bài viết: 15
Ngày tham gia: Thứ 7 28/05/2011 11:59 am
Has thanked: 1 time
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by moitinhdau » Thứ 3 14/01/2014 9:47 am

Mình có đoạn code bên tàng kinh các như sau:
MÃ: CHỌN TẤT CẢ

Sub DuyêtDòngFile()
'truongphu
Static SôChuong%
Dim para As Paragraph
Dim MM$: MM = "ch" & ChrW(&H1B0) & ChrW(&H1A1) & "ng"
For Each para In ActiveDocument.Paragraphs
    If (InStr(para.Range.Text, MM)) Then
        para.Range.Font.Color = 255
        SôChuong = SôChuong + 1
    End If
Next
Tuy nhiên khi mình muốn tô đỏ dòng 1. abc ( file mình khoảng 500 trang)
Mình cho nó vào for
MÃ: CHỌN TẤT CẢ

for i =1 to 10
for j =1 to 90
Dim MM$: MM = i & ". " & ChrW(J)
Thì chạy rất chậm và nó bôi đỏ luôn đoạn jhfsaff 1. hfdsafs

Bác nào có thể giúp mình được ko?

Thêm 1 vấn đề nữa là khi gặp table nó sẽ bỏ qua và làm việc tiếp với đoạn dưới. Rất mong các bác chỉ giúp
Đầu trang
moitinhdau
Thành viên chính thức
Thành viên chính thức
Bài viết: 15
Ngày tham gia: Thứ 7 28/05/2011 11:59 am
Has thanked: 1 time
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by moitinhdau » Thứ 4 15/01/2014 11:39 am

Có cao thủ nào giúp mình với
Đầu trang
moitinhdau
Thành viên chính thức
Thành viên chính thức
Bài viết: 15
Ngày tham gia: Thứ 7 28/05/2011 11:59 am
Has thanked: 1 time
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by moitinhdau » Thứ 6 17/01/2014 11:04 am

Làm sao để nó không đọc giá trị trong bảng thế các bác
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 7 18/01/2014 9:30 am

moitinhdau đã viết:
Làm sao để nó không đọc giá trị trong bảng thế các bác
Trong Paragraph, nếu thấy có Table thì bỏ qua, dùng lệnh GoTo
MÃ: CHỌN TẤT CẢ

For Each para In ActiveDocument.Paragraphs
If para.Range.Tables.Count > 0 Then GoTo SkipTables
    If (InStr(para.Range.Text, MM)) Then
        para.Range.Font.Color = 255
    End If
SkipTables:
Next
moitinhdau đã viết:
Thì chạy rất chậm và nó bôi đỏ luôn đoạn jhfsaff 1. hfdsafs
* Chạy rất chậm: file word của bạn 500 trang là nhẹ. Trên một file 20MB với máy tính bèo vẫn chạy nhanh. Bạn có thể xem lại các vòng lặp, chúng có động tác nào thừa và rối không?

* Bôi đỏ luôn đoạn...
Là đúng rồi, vì Paragraph là cả một câu nằm giữa 2 dấu xuống dòng. do đó lệnh sau áp dụng cho cả câu:
para.Range.Font.Color = 255

Để bôi đỏ cụm từ mong muốn, bạn phải dùng Selection chọn chúng rồi mới bôi đỏ.
Code về Selection trong chủ đề nầy viết rất nhiều, bạn chịu khó đọc lại...
moitinhdau đã viết:
có đoạn code bên tàng kinh các như sau:
he he, không ngờ code tôi viết phiêu giạt xa xa...
moitinhdau đã viết:
nick của bạn sâu đậm lắm!
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
moitinhdau
Thành viên chính thức
Thành viên chính thức
Bài viết: 15
Ngày tham gia: Thứ 7 28/05/2011 11:59 am
Has thanked: 1 time
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by moitinhdau » Thứ 7 18/01/2014 5:00 pm

Cảm ơn bác nhiều nhiều
Nếu bác thấy nick phù hợp với bác xin tặng bác luôn mình sẽ đặt nick mới là moitinhdau1 or moitinhdau2 cũng được :-)
Đầu trang
taytrongtay
Bài viết: 1
Ngày tham gia: Thứ 7 08/02/2014 10:14 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by taytrongtay » Thứ 7 08/02/2014 10:25 am

Thank mọi người trước nhé.
Sửa lần cuối bởi 1 vào ngày taytrongtay với 0 lần sửa trong tổng số.
Đầu trang
docaotri
Bài viết: 4
Ngày tham gia: Thứ 5 13/02/2014 11:57 pm
Has thanked: 2 times
xác định vị trí con trỏ
Gửi bài by docaotri » Thứ 6 14/02/2014 12:10 am

Xin chào mọi người.
Tôi thật sự không rành về VBA lắm, tôi có thắc mắc không biết hỏi ai, lên diễn đàn mong mọi người giúp đỡ.
Bác truongphu có viết:
MÃ: CHỌN TẤT CẢ

Do Until Selection.Range.Bookmarks.Exists("\EndOfDoc")
tôi hiểu: vòng lặp sẽ kết thúc khi con trỏ ở cuối văn bản.
vậy: vòng lặp sẽ kết thúc khi con trỏ ở cuối vùng được bôi đen thì viết như thế nào?
ở đây tôi không thao tác trên toàn văn bản, mà chỉ bôi đen một phần và thao tác trên phần đó.
Xin chân thành cảm ơn.
Đầu trang
docaotri
Bài viết: 4
Ngày tham gia: Thứ 5 13/02/2014 11:57 pm
Has thanked: 2 times
Gửi bài by docaotri » Thứ 6 14/02/2014 8:18 am

Mong moi nguoi giup.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 2 17/02/2014 8:46 am

docaotri đã viết:
vậy: vòng lặp sẽ kết thúc khi con trỏ ở cuối vùng được bôi đen thì viết như thế nào?
Bạn dùng code bình thường; tuy nhiên phải khai đối số của .Wrap là wdFindAsk
MÃ: CHỌN TẤT CẢ

.Wrap = wdFindAsk
nếu viết
MÃ: CHỌN TẤT CẢ

.Wrap = wdFindContinue
chúng sẽ thay hết văn bản

Không cần dùng code như:
docaotri đã viết:
Do Until Selection.Range.Bookmarks.Exists("\EndOfDoc")
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
207 bài viết    …   7   …  
Quay về
Trang chủDiễn đànThời gian được tính theo giờ UTC+07:00 UTC+7Xoá cookie của websiteLiên hệ chúng tôi
Đã tích hợp phpBB® Forum Software © phpBB Limited

Vietnamese language pack for phpBB 3.2.x download and support.

PRIVACY_LINK | TERMS_LINK



Page 8


Câu lạc bộ Visual Basic
.:: Nơi trao đổi về ngôn ngữ Visual Basic ::.

Bỏ qua nội dung

Nhập từ khóa tìm kiếm…
Đường dẫn nhanhTrợ giúpĐăng nhập
Trang chủDiễn đànTHẮC MẮC - TRAO ĐỔI - THẢO LUẬNVisual Basic for Application (VBA)
Trao đổi về Word VBA Mời vào đây!
Điều hành viên: tungblt

Nội quy chuyên mục

Tìm kiếm trong chủ đề này…
207 bài viết    …   8    
dvtruyen
Bài viết: 1
Ngày tham gia: Thứ 6 14/03/2014 8:31 pm
Mọi người ai thông thao macro trong excel 2010 thì hộ mình v
Gửi bài by dvtruyen » Thứ 3 18/03/2014 8:52 am

[quote="truongphu"]Mở hàng cho topic: Mọi người a thông thao macro trong excel 2010 thì hộ mình với.

Mình đang xây dựng quản lý về môn học đào tạo theo tín chỉ, có anh em nào rảnh và biết thì hộ mình với
Các hàm cơ bản trong macro ấy.
Đầu trang
Viet Roy
Bài viết: 2
Ngày tham gia: Thứ 4 19/03/2014 10:11 am
Has thanked: 2 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Viet Roy » Thứ 4 19/03/2014 10:21 am

Di chuyển toàn bộ các đối tượng là TEXT sang trái 1 khoảng là 10. Có bác nào biết code bài này hông ạ
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 6 21/03/2014 8:23 am

Viet Roy đã viết:
Di chuyển toàn bộ các đối tượng là TEXT sang trái 1 khoảng là 10. Có bác nào biết code bài này hông ạ
Đã trả lời ở bài viết của riêng bạn bên dưới
dvtruyen đã viết:
Mọi người a thông thao macro trong excel 2010 thì hộ mình với.
Mình đang xây dựng quản lý về môn học đào tạo theo tín chỉ, có anh em nào rảnh và biết thì hộ mình với
Các hàm cơ bản trong macro ấy.
Macro là các sus thi hành. Muốn tìm các hàm đã dùng trong macro thì phải có macro cụ thể.
Có lẽ ý bạn là các hàm căn bản trong Excel

sau đây là các hàm căn bản. chép từ GPE
TẬP TIN ĐÍNH KÈM
Căn Bản Excel.rar
(730.64 KiB) Đã tải về 349 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
dncldncldncl
Bài viết: 3
Ngày tham gia: Thứ 2 21/10/2013 10:40 pm
Has thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by dncldncldncl » Chủ nhật 08/06/2014 9:08 pm

Cho mình hỏi tí:
1. làm cách nào để tìm hoặc chữ này hoặc chữ kia trong seclection.find
vd:
MÃ: CHỌN TẤT CẢ

.text = "(Đệ|Thứ)"
thì kết quả tìm được là "Đệ" hoặc "Thứ"
2. nếu không chọn
MÃ: CHỌN TẤT CẢ

.MatchWildcards = True
thì đoạn này
MÃ: CHỌN TẤT CẢ

.text = "([0-9])"
sẽ bị sai???
3. nếu sử dụng
MÃ: CHỌN TẤT CẢ

.MatchWildcards = True
thì khi tìm, nó sẽ phân biệt chữ hoa với chữ thường. vd: tìm "đệ" thì sẽ không tìm được chữ "Đệ" và "đỆ" và "ĐỆ". có cách khắc phục nào không?
Nếu điều thắc mắc của mình chính là điểm yếu của seclection.find => mình chuyển sang dùng "Regular Expressions". Khổ nỗi cái này cũng có điểm yếu là không tự tô đen kết quả tìm được. vd:
MÃ: CHỌN TẤT CẢ

  Set regEx = New RegExp            ' Create a regular expression.
  regEx.Pattern = "(aaa|bbb|ccc)"         ' Set pattern.
  regEx.IgnoreCase = False           ' Set case insensitivity.
  regEx.Global = True           ' Set global applicability.
  
  Set matches = regEx.Execute(ActiveDocument.Range.text)    ' Execute search.
  Match = matches(1)
  Match.FirstIndex
Match.FirstIndex trả về giá vị trí của từ kiếm được là sai nếu trong word có table => không có được vị trí để tô đen đoạn văn bản
Xin mọi người chỉ giúp cách giải quyết các vấn đề trên.
Đầu trang
thanhthao195
Bài viết: 2
Ngày tham gia: Thứ 2 09/06/2014 12:39 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by thanhthao195 » Thứ 3 10/06/2014 9:47 am

*** Viết Macro Word về Heading
Mình có tài liệu file *.docx, trong đó có nhiều chương, đầu đề mỗi chương đều gắn Heading1. Khi đọc tới một đoạn văn bất kỳ trong file, mình muốn biết đoạn văn này nằm ở chương nào ? tên đầu đề là gì ? Nhưng không biết viết Macro như thế nào ? Nhờ các bạn cao minh chỉ giúp với.
Đầu trang
dncldncldncl
Bài viết: 3
Ngày tham gia: Thứ 2 21/10/2013 10:40 pm
Has thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by dncldncldncl » Thứ 3 10/06/2014 4:49 pm

truongphu đã viết:
Viết lại Sub TìmThayNgay vì thấy rườm rà...

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub TìmThayNgay()
 With Selection.Find
    .Execute Replace=wdReplaceOne
    While .Found
        .Execute Replace=wdReplaceOne
    Wend
 End With
End Sub
GeSHi © Codebox Plus Extension


;;)
cả 2 code đều gặp 1 vấn đề là nếu
.text="aaa"
.Replacement.Text = "aaa"
thì sẽ treo máy vì vòng lặp vô hạn. lý do:
lệnh
MÃ: CHỌN TẤT CẢ

Selection.Find.Wrap = wdFindContinue
Nếu không thấy sẽ tự động về lại đầu trang để tìm mà không cần hỏi
và lệnh
MÃ: CHỌN TẤT CẢ

While Selection.Find.Found
        .Execute Replace:=wdReplaceOne
Wend
"Selection.Find.Found" sẽ luôn là true nếu ".text" và ".Replacement.Text" giống nhau hoặc chuỗi ".text" là chuỗi con của ".Replacement.Text"
Xin bác cho ý kiến.
ps: Bác truongphu trả lời giúp câu hỏi trước của tôi với
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 5 12/06/2014 7:12 am

dncldncldncl đã viết:
...
Xin bác cho ý kiến
Đúng như bạn nhận xét.

1- Nếu văn bản ngắn, bạn có thể thay wdFindContinue với wdFindAsk và xử lý tùy tình huống.
2- Nếu văn bản dài, bạn cứ dùng wdFindContinue: Tôi sử dụng trên doc 20MB (truyện huyễn huyễn), thấy chúng chạy sau một hồi cũng thoát! không treo máy!
vd: tìm chữ lãnh và thế bằng lãnh địa. Kết quả là lãnh địa địa địa địa.
Chịu khó tìm địa địa và thay bằng địa là xong.
dncldncldncl đã viết:
ps: Bác truongphu trả lời giúp câu hỏi trước của tôi với
dncldncldncl đã viết:
1. làm cách nào để tìm hoặc chữ này hoặc chữ kia trong seclection.find
VBA Word không hổ trợ
dncldncldncl đã viết:
.text = "([0-9])"
Khi .MatchWildcards = True thì VBA sẽ đọc text là chữ chỉ có 1 ký tự số.
Không khai báo tức mặc định (.MatchWildcards = False) thì VBA sẽ đọc text là ([0-9])
dncldncldncl đã viết:
phân biệt chữ hoa với chữ thường
Đó là .MatchCase = True, nếu false thì hoa hay thường cũng dùng tuốt
dncldncldncl đã viết:
chuyển sang dùng "Regular Expressions". Khổ nỗi cái này cũng có điểm yếu là không tự tô đen
Bạn thử dùng code:
MÃ: CHỌN TẤT CẢ

            For Each strMatch In objRegEx.Execute(strSearch)
                        ''' Làm gì Ðây?
            Next
Tại vị trí Làm gì Ðây? Bạn thử cho Selection.text = strMatch.text (Tôi chưa thử, chỉ là ý tưởng). Nếu êm thì các chữ tìm được highlight cũng OK

Bạn làm VB mấy năm rồi mà nhuyễn thế?
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
dncldncldncl
Bài viết: 3
Ngày tham gia: Thứ 2 21/10/2013 10:40 pm
Has thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by dncldncldncl » Thứ 5 19/06/2014 7:01 pm

cám ơn ý kiến bác truongphu. VB mình mới làm có mấy tháng thôi. Chủ yếu là có căn bản lập trình pascal C C# nên qua VBA cũng dễ. Mình học VBA từ bác chứ đâu. còn vấn đề của mình thì 1 file truyện chắc hiếm có table lắm nên mình bỏ qua yếu điểm Regular Expressions rồi.
Giờ lại phát sinh vấn đề lớn là find and replace. Nếu sử dụng Ctrl + F để tìm trong Navigation thì có cả SỐ kết quả tìm được và cực nhanh.
Còn nếu tìm bằng code nó không hỗ trợ => tự lập trình.
Mình thử cả 2 phương pháp là
PP1: tìm và đếm từng từ (pp này thì rất lâu vì dùng vòng lặp)
PP2: cho nó replace rồi đếm số chữ thay đổi => tính toán ra số từ Replace (pp này thì càng lâu vì dùng "ActiveDocument.Characters.Count")
Với file Word > 20mb thì chạy tới tối. đùa thôi chứ rất lâu so với nhấn Ctr F.
Có cao thủ nào biết sử dụng Navigation trong lập trình hoặc giải thuật nhanh tìm và thay mà có đếm kq không. xin cám ơn
Đầu trang
rooneyp
Bài viết: 1
Ngày tham gia: Thứ 6 20/06/2014 4:13 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by rooneyp » Thứ 6 20/06/2014 4:17 pm

Chào mọi người.Em cần tìm một người giỏi về VBA làm giúp em một assignment về VBA. Em sẽ trả phí đầy đủ ạ. Em cần gấp ạ.

Ai có thể giúp đc em xin liên lạc: rooneypham91@gmail.com
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 6 20/06/2014 5:56 pm

dncldncldncl đã viết:
tính toán ra số từ Replace (pp này thì càng lâu vì dùng "ActiveDocument.Characters.Count")
Dùng Characters.Count với file lớn sẽ lâu. Trang mvps.org nổi tiếng cũng đề xuất dùng cách nầy, tôi đọc thấy buồn cười! :D
http://word.mvps.org/FAQs/MacrosVBA/Get ... ements.htm

Khi bảng Dialogs(wdDialogEditReplace) chạy tìm và thay, thực ra chúng cũng đếm! và đếm là phương tiện nhanh cùng chính xác nhất!
Bạn thử dùng:
MÃ: CHỌN TẤT CẢ

    Dim J&
        Do While Selection.Find.Execute _
        (Replace:=wdReplaceOne, Forward:=True) = True
            J = J + 1
            Selection.MoveRight wdWord, 1, wdMove
        Loop
    Msgbox "Sô lân tìm và thay là: " & J
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
btamsgn
Thành viên chính thức
Thành viên chính thức
Bài viết: 47
Ngày tham gia: Thứ 5 10/04/2008 4:40 pm
Has thanked: 3 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by btamsgn » Thứ 3 08/07/2014 2:43 pm

Chào a.Phu,
Trong access mình có viết code như sau:
Function houral(ByVal nnt As Long) As String
Canday$("Giasp,AAst,Bisnh,Ddinh,Maaju,Kyr,Canh,Taan,Nhaam,Qusy")
khoiCan$("Giasp,Bisnh,Maaju,Canh,Nhaam,Giasp,Bisnh,Maaju,Canh,Nhaam")
Chi$ = Split("Suwru,Suwru,Suwru,Daafn,Daafn,Maxo,Maxo,Thifn,Thifn,Tij,Tij,Ngoj,Ngoj,Mufi,Mufi,Thaan,Thaan,Daaju,Daaju,Tuaast,Tuaast,Howji,Howji,Tys,Tys,Tys", ",")
houral = VN(Chi(Int(nnt)))
End Function

Tuy nhiên hàm trả về kết quả Chi giờ đúng còn "Can giờ" không đúng.

Làm cách nào để trả về kết quả Can Chi giờ theo ý sau:
Canday$("Giasp,AAst,Bisnh,Ddinh,Maaju,Kyr,Canh,Taan,Nhaam,Qusy")
khoiCan$("Giasp,Bisnh,Maaju,Canh,Nhaam,Giasp,Bisnh,Maaju,Canh,Nhaam")
Tuy nhiên cứ 2 giờ là tăng lên 1 can
vd: 23-1: Tý, Can Ngày : Giáp thì =>Giáp Tý
1-3: Sửu, Can Ngày : Giáp thì =>Ất Sửu
....
21-23: Hợi, Can Ngày : Giáp thì =>Ất Hợi

vd:23-1: Tý, Can Ngày : Bính thì =>Mậu Tý
1-3: Sửu, Can Ngày : Bính thì =>Kỷ Sửu
....
21-23: Hợi, Can Ngày : Bính thì =>Kỷ Hợi


Rất mong nhận được công thức tính trên, thanks
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 3 08/07/2014 8:12 pm

btamsgn đã viết:
Làm cách nào để trả về kết quả Can Chi
Cách đây mấy năm bạn có hỏi trong Box thủ thuật, giờ tôi xem mới thấy.... :D
[Tuy nhiên cớ sao bạn lại trao đổi CanChi ở chủ đề MS Word chứ?]
btamsgn đã viết:
Canday$("Giasp,AAst,Bisnh,Ddinh,Maaju,Kyr,Canh,Taan,Nhaam,Qusy")
khoiCan$("Giasp,Bisnh,Maaju,Canh,Nhaam,Giasp,Bisnh,Maaju,Canh,Nhaam")
Chi$ = Split("Suwru,Suwru,Suwru,Daafn,Daafn,Maxo,Maxo,Thifn,Thifn,Tij,Tij,Ngoj,Ngoj,Mufi,Mufi,Thaan,Thaan,Daaju,Daaju,Tuaast,Tuaast,Howji,Howji,Tys,Tys,Tys", ",")
Sao bạn viết rối thế? Sửu và Tí bạn cho đến 3 thành phần trong dãy! rồi các chi còn lại mỗi em là 2...

Tôi lục function cũ tôi đã viết:
MÃ: CHỌN TẤT CẢ

Private Function NamAmLich$(ByVal Year%)
    Dim Can$(), Chi$()  ' truongphu
    Can = Split("Canh Tân Nhâm Qúy Giáp Ât Bính Ðinh Mâu Ky")
    Chi = Split("Thân Dâu Tuât Ho'i Tí Suu Dân Mão Thìn Ty Ngo Mùi")
    NamAmLich = Can(Year Mod 10) & " " & Chi(Year Mod 12)
End Function
Cớ gì Can bắt đầu là Canh và Chi là Thân?
Can có 10, mà năm Can DL có đuôi là 0 nên Can bắt đầu chuỗi, để khi split, Can(0) sẽ là Canh, cứ thế theo thứ tự...
Và Chi có 12. Để khớp với mỗi năm Can, Chi(0) sẽ là Thân.
Đương nhiên function trên chỉ đúng cho đa số ngày giữa năm: Đầu năm DL (hơn 1 tháng) sẽ không đúng!

Ngày cũng tuần tự như năm, để khớp Can Chi trên, tôi tính ra mốc 1/4/1800
MÃ: CHỌN TẤT CẢ

Private Function NgayAmLich$(ByVal Ngày As Date)
    Dim Can$(), Chi$()  ' truongphu
    Can = Split("Canh Tân Nhâm Qúy Giáp Ât Bính Ðinh Mâu Ky")
    Chi = Split("Thân Dâu Tuât Ho'i Tí Suu Dân Mão Thìn Ty Ngo Mùi")
    NgayAmLich = Can(DateDiff("d", #4/1/1800#, Ngày) Mod 10) & " " & _
    Chi(DateDiff("d", #4/1/1800#, Ngày) Mod 12)
End Function
function nầy thì tuyệt đối đúng, vì nó đếm từng ngày!

Riêng tháng thì phức tạp, vì ÂL có tháng nhuận...
btamsgn đã viết:
Tuy nhiên cứ 2 giờ là tăng lên 1 can
vd: 23-1: Tý, Can Ngày : Giáp thì =>Giáp Tý
1-3: Sửu, Can Ngày : Giáp thì =>Ất Sửu
....
21-23: Hợi, Can Ngày : Giáp thì =>Ất Hợi

vd:23-1: Tý, Can Ngày : Bính thì =>Mậu Tý
1-3: Sửu, Can Ngày : Bính thì =>Kỷ Sửu
....
21-23: Hợi, Can Ngày : Bính thì =>Kỷ Hợi
Câu hỏi chính nầy khá phức tạp, vì giờ Giáp tí bắt đầu từ ngày Giáp tí, cứ tuần tự mà tính, hôm sau là ngày Ất Sửu và giờ bắt đầu là Bính tí.
Hẹn ngày mai mốt nha... Tôi sẽ viết lại function giờ cho bạn
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
btamsgn
Thành viên chính thức
Thành viên chính thức
Bài viết: 47
Ngày tham gia: Thứ 5 10/04/2008 4:40 pm
Has thanked: 3 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by btamsgn » Thứ 3 08/07/2014 10:16 pm

Cảm ơn a.Phú,

còn đây là ý tưởng nhưng viết code thế nào để mảng 12chi mặc định 1 là dần, 2 là mão,...thì mình vẫn chưa biết cách viết.
1.về cách lấy chi tháng âm lịch mặc định: Tháng 1 là Dần, 2 là Mão...đến tháng 12 sửu
về cách lấy can tháng âm lịch theo hồ ngọc đức: năm*12+tháng âm lịch +3 mod 10(với Số dư 0 là Giáp, 1 là Ất v.v. )
hoặc dựa vào Can năm âm lịch để tính như năm Giáp,Kỷ Khởi Bính dần; Ất,canh khởi Mậu dần; Bính,tân khởi Canh dần; Đinh, nhâm khởi Nhâm dần;Mậu,quý khởi Giáp dần
2.về cách lấy chi giờ âm lịch mặc định: 23-1 là Tý, 1-3 là Sửu...đến 21-23 hợi
khi tạo mãng chi giờ như trên thì khi gõ vào textbox thì int(1)=>Sửu hay int(20)=>Tuất v.v
về cách khởi Can giờ theo can ngày âm lịch như năm Giáp,Kỷ Khởi Giáp Tý; Ất,canh khởi Bính Tý; Bính,tân khởi Mậu Tý; Đinh, nhâm khởi Canh Tý;Mậu,quý khởi Nhâm Tý.

về cách viết code ý tưởng trên như thế nào thì mình vẫn chưa biết cách.

Rất mong công thức từ a.Phú, thanks.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 4 09/07/2014 7:41 am

btamsgn đã viết:
Rất mong công thức từ a.Phú, thanks.
Mất 3 tiếng! :P

1- Mỗi ngày 12 Chi giờ, vậy 5 ngày là 60 Chi giờ. Đây là BSCNN của Chi và Can. Do đó mỗi 5 ngày Can giờ bắt đầu sẽ trở lại.
Can giờ bắt đầu ngày là: Giáp, Bính, Mậu, Canh, Nhâm.
2- Dãy "Giáp Ất Bính Đinh Mậu Kỹ canh Tân Nhâm Quý" khi Split đưa vào mảng Chi thì Chi(0) là Giáp, Chi(1) là Ất... Chi(9) là Nhâm. Số phần tử viết gọn lần lượt là 0 1 2 3 4 5 6 7 8 9
Mà Can giờ khởi đầu chỉ 5, đó là Giáp =Chi(0), Bính = Chi(2), Mậu = Chi(4), Chi(6) = Canh và Nhâm = Chi(8). Số phần tử viết gọn lần lượt là 0 2 4 6 8
3- Ta thấy nếu dãy 0 1 2 3 4 5 6 7 8 9 nhân cho 2, có được 0 2 4 6 8 10 12 14 16 18, và nếu chỉ lấy hàng đơn vị thì dãy 10 số nầy biến thành dãy 5 số: 0 2 4 6 8 khớp dãy Can giờ khởi đầu nêu trên.

Thế là OK!
Công thức tính Can Chi của giờ liên quan đến Can ngày và giờ yêu cầu tính

Bạn yêu cầu tính giờ Tí từ 23:00:00 đến 0:59:59 đây là cách tính xưa, không đúng logic của ngày từ 0:00:00 đến 23:59:59
Mà cách tính nầy lại thêm phức tạp. Tôi gọi Function cách tính nầy là GioAmLich23_1

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Function GioAmLich23_1$(ByVal Gio%, ByVal Ngày As Date)
    GioAmLich23_1 = Can((((DateDiff("d", #4/1/1800#, Ngày) * 2 - 4) Mod 10) + ((Gio + 1) \ 2)) Mod 10) & " " & _
    Chi((((Gio + 1) \ 2) + 4) Mod 12) ' truongphu
End Function
GeSHi © Codebox Plus Extension


Nếu bạn muốn tính giờ Tí theo hiện đại từ 0:00:00 đến 1:59:59
Tôi gọi function nầy là GioAmLich0_2

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Private Function GioAmLich0_2$(ByVal Gio%, ByVal Ngày As Date)
    GioAmLich0_2 = Can((((DateDiff("d", #4/1/1800#, Ngày) * 2 - 4) Mod 10) + (Gio \ 2)) Mod 10) & " " & _
    Chi(((Gio \ 2) + 4) Mod 12) ' truongphu
End Function
GeSHi © Codebox Plus Extension


Khai báo 2 mảng Can Chi cho 2 function trên:

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
    Dim Can$(), Chi$()
Private Sub Form_Load()
    Can = Split("Canh Tân Nhâm Qúy Giáp Ât Bính Ðinh Mâu Ky")
    Chi = Split("Thân Dâu Tuât Ho'i Tí Suu Dân Mão Thìn Ty Ngo Mùi")
End Sub
GeSHi © Codebox Plus Extension


4- Hai function trên khác nhau ở ((Gio + 1) \ 2)) và (Gio \ 2))
Thêm +1 vì GioAmLich23_1 nhanh hơn 1 giờ. Vd tính 23 giờ, sẽ là 23 + 1 = 24 giờ bắt đầu ngày mới
5- (DateDiff("d", #4/1/1800#, Ngày) là xác định Can ngày đang tính. Công thức nầy có trong function bài viết trước.
6- Sau đó có * 2 đã nói ở mục 3
7- có - 4, Vì Mục 2 và 3 cho Giáp là 0. Mà ở đây đang dùng thì Giáp là 4, nên phải trừ 4
8- Mod 10 vì trước đó là con số rất lớn, ta chỉ cần hàng đơn vị
9- + (Gio \ 2) là Can thay đổi theo mỗi 2 giờ

10- Chi giờ:
(Gio \ 2) là Chi thay đổi theo mỗi 2 giờ
+ 4 để trả giá trị khởi đầu luôn là Tí
Mod 12 lấy số dư của 12 Chi

11- Ứng dụng.
btamsgn đã viết:
gửi bởi btamsgn » Chủ nhật 19/12/2010 7:11 pm
...
ví dụ : ngày 19 tháng 12 năm 2010 vào lúc 17:30
Âm lịch: Ngày 14 tháng m/một, năm 2010 (ngày Quý Mão, tháng Mậu Tí, năm Canh Dần; giờ Tân Dậu)
MÃ: CHỌN TẤT CẢ

MsgBox GioAmLich23_1(17, #12/19/2010)
:>
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
btamsgn
Thành viên chính thức
Thành viên chính thức
Bài viết: 47
Ngày tham gia: Thứ 5 10/04/2008 4:40 pm
Has thanked: 3 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by btamsgn » Thứ 4 09/07/2014 8:55 am

Chào a.Phú,

Sau khi kiểm tra hàm GioAmLich23_1, nhập giờ từ 23:00:00 đến 0:59:59 thì kết quả bị sai.
Các giờ khác đúng chỉ mỗi giờ Tý là Can bị sai.

Thanks,
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 4 09/07/2014 10:38 am

btamsgn đã viết:
Sau khi kiểm tra hàm GioAmLich23_1, nhập giờ từ 23:00:00 đến 0:59:59 thì kết quả bị sai.
Đối số giờ của hàm là số Integer
truongphu đã viết:
Function GioAmLich23_1$(ByVal Gio%, ByVal Ngày As Date)
Bạn nhập dạng "hh:mm:ss" là dạng String thì làm sao hàm chạy tốt? Chúng coi chuỗi là số 0, và ra kêt quả trên giờ = 0

Tôi có ví dụ ở trên để bạn quen:
MsgBox GioAmLich23_1(17, #12/19/2010#)

Ngày trong VB6, có dấu thăng # ở hai bên. bên trong là Tháng, ngày, năm hay M/D/YYYY
(Việt Nam quen D/M/YYYY)

Để bạn dùng được dạng "hh:mm:ss", đối số giờ trong hàm phải sửa thành String
và xử lý chuỗi nầy trả về kiểu số: với function B như sau

MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Function GioAmLich23_1B$(ByVal Gio$, ByVal Ngày As Date)
    Dim GG$() GG = Split(Gio, "")
    GioAmLich23_1B = Can((((DateDiff("d", #4/1/1800#, Ngày) * 2 - 4) Mod 10) + ((Int(GG(0)) + 1) \ 2)) Mod 10) & " " & _
    Chi((((Int(GG(0)) + 1) \ 2) + 4) Mod 12) ' truongphu
End Function
GeSHi © Codebox Plus Extension
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
btamsgn
Thành viên chính thức
Thành viên chính thức
Bài viết: 47
Ngày tham gia: Thứ 5 10/04/2008 4:40 pm
Has thanked: 3 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by btamsgn » Thứ 4 09/07/2014 11:48 am

Chào a.Phú,

Ý mình muốn nói là hàm GioAmLich23_1 trả về kết quả sai ở Can giờ khi nhập int(23) hay int(24)
vd: ngày 09/07/2014: Tân Tị=> khi nhập 23 thì kết quả trả về "Canh Tý"(đúng : Mậu Tý)
vd:ngày 09/07/1971: Ất Mùi=> khi nhập 23 thì kết quả trả về "Mậu Tý"(đúng : Bính Tý)
...
Thanks,
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 4 09/07/2014 3:26 pm

Chào bạn btamsgn
1- nick của bạn có tiếp vĩ ngữ sgn, bạn đang ở Sài gòn hả?
và nếu đúng, bạn phải lớn tuổi vì trẻ quen dùng TPHCM

2-
btamsgn đã viết:
Ý mình muốn nói là hàm GioAmLich23_1 trả về kết quả sai ở Can giờ khi nhập int(23) hay int(24)
Nghĩa là Hàm chạy tốt trong mọi int khác?
Như thế thì Hàm hoạt động tốt!

3- Nếu bạn dùng hàm GioAmLich0_2, Tôi đảm bảo bạn sẽ dùng vô tư!
vì sao? vì nó khớp hệ thống giờ/ngày thông dụng

4- Hôm nay ngày 9/7/2014, cứ mỗi tiếng bạn dùng hàm GioAmLich23_1 một lần, tất cả trả về ok. Nhưng từ 23 giờ hôm nay trở đi, bạn bảo lúc đó vẫn là ngày 9/7/2014 thông dụng, hay theo hàm GioAmLich23_1 đã sang ngày mới?
Thế nên khi bạn nhập 23, hoặc 23:33 trên hàm GioAmLich23_1B, chúng đều trả về Canh Tí, đó là ngày Nhâm Ngọ 10/7/2014. Hàm đã xem rằng qua ngày mới, thế thôi.

Hay ngược lại, trên hàm GioAmLich23_1, muốn có kết quả giờ X mà 23 <= X = < 24 phải là Mậu Tí, bạn phải cho ngày là 8/7/2014; vì từ lúc đó, GioAmLich23_1 (theo yêu cầu của bạn) đã sang ngày mới...

5- Có lẽ bạn thấy lúng túng, bạn dùng thử project sau:
untitled.JPG
untitled.JPG (35.83 KiB) Đã xem 11996 lần
project:
TẬP TIN ĐÍNH KÈM
Ngày Gio Âm Lich 2.rar
(2.39 KiB) Đã tải về 301 lần
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
btamsgn
Thành viên chính thức
Thành viên chính thức
Bài viết: 47
Ngày tham gia: Thứ 5 10/04/2008 4:40 pm
Has thanked: 3 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by btamsgn » Thứ 4 09/07/2014 4:11 pm

Chào a.Phú,

Cảm ơn anh đã giải thích.

Để 23.59 thuộc ngày trước thì lấy ngày -0.1 và thêm điều kiện thì kết quả trả về đúng.

Function GioAmLich23_1$(ByVal Gio%, ByVal Ngày As Date)
GioAmLich23_1 = Can((((DateDiff("d", #4/1/1800#, Ngày-0.1) * 2 - 4) Mod 10) + ((Gio + 1) \ 2)) Mod 10) & " " & _
Chi((((Gio + 1) \ 2) + 4) Mod 12) ' truongphu
End Function

Thanks,
Đầu trang
toancapba
Bài viết: 7
Ngày tham gia: Thứ 3 04/03/2014 10:53 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by toancapba » Chủ nhật 02/11/2014 8:27 pm

Chào Anh Phú !
Nhờ anh giúp tôi code làm sao mình chuyển một bảng ( một cột ) trong word thành từ file txt, mỗi nội dung một ô thành 1file txt.
Làm sao lấy dữ liệu trong clipboar thành một string
Xin cảm ơn Anh !
Đầu trang
207 bài viết    …   8    
Quay về
Trang chủDiễn đànThời gian được tính theo giờ UTC+07:00 UTC+7Xoá cookie của websiteLiên hệ chúng tôi
Đã tích hợp phpBB® Forum Software © phpBB Limited

Vietnamese language pack for phpBB 3.2.x download and support.

PRIVACY_LINK | TERMS_LINK


Page 9


Câu lạc bộ Visual Basic
.:: Nơi trao đổi về ngôn ngữ Visual Basic ::.

Bỏ qua nội dung

Nhập từ khóa tìm kiếm…
Đường dẫn nhanhTrợ giúpĐăng nhập
Trang chủDiễn đànTHẮC MẮC - TRAO ĐỔI - THẢO LUẬNVisual Basic for Application (VBA)
Trao đổi về Word VBA Mời vào đây!
Điều hành viên: tungblt

Nội quy chuyên mục

Tìm kiếm trong chủ đề này…
207 bài viết    …   9   
anhcau
Bài viết: 8
Ngày tham gia: Thứ 7 06/07/2013 1:18 pm
Ứng dụng dịch Tiếng Anh và một số ngoại ngữ trong MS Word
Gửi bài by anhcau » Thứ 4 21/01/2015 3:11 pm

Chào các bạn và các anh chị em trong Câu lạc bộ Visual Basic (gọi chung là các bạn cho tiện ạ)
Chúc một năm mới an khang - mạnh khỏe

Như các bạn biết là khi dịch tài liệu Tiếng Anh hay tiếng Pháp sang tiếng Việt cái khó là ráp thành câu cho đúng ngữ pháp Việt. Hiện có ứng dụng Google dịch nhưng khó sử dụng được tốt.
Trong quá trình dịch chuyên đề, tôi thấy có một số từ cứ lặp đi lặp lại với tần suất lớn. Thí dụ từ I, you, me, is, are,.... và một số dạng bị động của nó. Chúng ta có thể dịch tay (có nghĩa là dịch trực tiếp) rồi đánh máy lại, hay thay thế dùng cách Replace trong chương trình soạn thảo văn bản. Nhưng nó tồn tại các nhược điểm sau:
1- Nhàm chán vì phải lặp đi lặp lại các từ quen
2- Khó xem lại ngữ pháp hay cấu trúc câu trong một thời gian dài tiếp tục dịch lại

Thí dụ dưới đây cho chúng ta thấy các từ đã thay và các từ chưa thay nằm hỗn độn với nhau:

“Mẹ/Ta đang phái/gửi/sai Mẹ Ta to các con/các bạn vào ngày Thứ mười hai của mỗi tháng [để] nói [cho/với] cách riêng to this nation. If tâm hồn/các con tim không/đừng thay đổi; if the sự thiếu vắng tình yêu trong các tâm hồn is not đã giải quyết; quốc gia/dân tộc của các con/các bạn thay đổi; if the sự thiếu vắng tình yêu trong các tâm hồn is not đã giải quyết; quốc gia/dân tộc của các con/các bạn sẽ (hãy) tiếp tục to chịu đựng internal strife.”

Nếu không phân biệt chữ đậm chữ nhạt, thì bản văn có dạng sau đây:

“Mẹ/Ta đang phái/gửi/sai Mẹ Ta to các con/các bạn vào ngày Thứ mười hai của mỗi tháng [để] nói [cho/với] cách riêng to this nation. If tâm hồn/các con tim không/đừng thay đổi; if the sự thiếu vắng tình yêu trong các tâm hồn is not đã giải quyết; quốc gia/dân tộc của các con/các bạn thay đổi; if the sự thiếu vắng tình yêu trong các tâm hồn is not đã giải quyết; quốc gia/dân tộc của các con/các bạn sẽ (hãy) tiếp tục to chịu đựng internal strife.”

Thật là khó chịu cho người dịch phải không?
3- Nếu là văn bản hàng ngàn trang thì việc Replace rất nặng nề, khó khả thi.
Như thế hẳn các bạn sẽ nghĩ đến các chương trình dịch thuật chuyên nghiệp. Nhưng lại đụng đến các chi phí, tiền bạc, thời gian học về phần mềm mà chưa chắc gì đã chọn đúng phần mềm cần tìm. Ngoài ra còn chuyện dịch theo kiểu ngôn ngữ của mỗi người thì sao? Bạn cũng phải định nghĩa lại một số cho máy nó hiểu chứ, hay là hết mọi từ đây, nào ai biết được.

TÔI ĐỀ XUẤT MỘT CÁCH BỔ TRỢ KHÁC.
Cách này thực chất là dùng Marco VB trong MS Word để xử lý, theo dạng thay đoạn này = đoạn kia nhưng có lưu lại các từ này thành file .xls được; Cách này có ưu điểm:

1- Lưu trữ được thành file .xls dễ dàng sử dụng
2- Tái sử dụng cho các bản văn tiếng Anh tương tự tiếp theo.
3- Có thể thay thế lập trình trên Word bằng trên Exel

Nhưng dĩ nhiên là có hạn chế, nghĩa là bạn phải tự dịch.

Để mô tả chúng ta cùng xét đoạn văn sau đây làm ví dụ

Đoạn văn A

I desire that My children come to Me under this title of Guadalupe, for in this way I will protect their faith.

"My children, that it is not for your physical well-being I come. But I come to capture and to vanquish your hearts and souls with My Holy Love...

My coming to you on the Twelfth of each month, to commemorate My Image of Guadalupe, must be a sign to My children of My maternal concern, My call to conversion, and a return to the faith. When I came to Juan Diego, I came to stop pagan rituals and convert the unchurched.

I will speak most profoundly in a Christmas message to all My children. Tonight, I am blessing you with My Blessing of Holy Love.

Therefore, see that Satan is the complacency that tries to take over your hearts in this regard. My children, I love you, I pray for all your intentions and intercede for you before the Throne of My Divine Son. Tonight, I impart to you My Motherly Blessing.

Such a soul could easily lose his way because he does not look within himself but looks outside himself seeking perfection, seeking more exterior grace. I desire salvation for each one of My children. I ask they seek not so much further signs and wonders, but to look at the heart of My message everywhere, there they will find the fullness of their search - Holy Love.
Một trong những cách đơn giản là các bạn (chuyên dịch thuật) sẽ thay thế trong file exel như sau:
My children = các con của Tôi.
Me = Tôi
I = Tôi
Và đoạn văn như sau:

Tôi desire that các con của Tôi come to Tôi under this title of Guadalupe, for in this way Tôi will protect their faith.

”các con của Tôi, that it is not for your physical well-being Tôi come. But Tôi come to capture and to vanquish your hearts and souls with My Holy Love.

My coming to you on the Twelfth of each month, to commemorate My Image of Guadalupe, must be a sign to các con của Tôi of My maternal concern, My call to conversion, and a return to the faith. When Tôi came to Juan Diego, Tôi came to stop pagan rituals and convert the unchurched.

Tôi will speak most profoundly in a Christmas message to all các con của Tôi. Tonight, Tôi am blessing you with My Blessing of Holy Love.

Therefore, see that Satan is the complacency that tries to take over your hearts in this regard. các con của Tôi, Tôi love you, Tôi pray for all your intentions and intercede for you before the Throne of My Divine Son. Tonight, Tôi impart to you My Motherly Blessing.

Such a soul could easily lose his way because he does not look within himself but looks outside himself seeking perfection, seeking more exterior grace. Tôi desire salvation for each one of các con của Tôi. Tôi ask they seek not so much further signs and wonders, but to look at the heart of My message everywhere, there they will find the fullness of their search - Holy Love.


Như thế khi ấy thật khó hiểu được các dạng thức của câu, vì trong tiếng Việt, I, Me đều biến thành "Tôi" cả, không phân biệt nữa. Cả từ "You" bây giờ có thể theo ngữ cảnh lại là "bạn" ; "ông" ; "chú" "bác" .... và trở thành vấn đề nan giải, tự nhiên bản dịch lại rẽ nhánh phức tạp hơn là chưa dịch. Vì vậy tôi đề xuất là dịch theo cụm từ. Tất cả các từ phải dịch theo ngữ nghĩa của nó; hoặc là cụm từ tối thiểu bằng hai từ trở lên và có giữ lại các từ mấu chốt để hiểu.


(còn tiếp)
Đầu trang
anhcau
Bài viết: 8
Ngày tham gia: Thứ 7 06/07/2013 1:18 pm
Ứng dụng dịch Tiếng Anh và một số ngoại ngữ trong MS Word
Gửi bài by anhcau » Thứ 5 22/01/2015 10:59 am

TIẾP SAU ĐÂY LÀ PHẦN MÃ THAY THẾ CÁC TỪ QUA CÁC FILE .xls


1- PHẦN MÃ THI HÀNH

MÃ: CHỌN TẤT CẢ

Option Explicit
' Chon biên tên_file_chon(1 To 100) nham muc dich giai phóng bô nho cua KQ thôi
Public tên_file_chon(1 To 150) As String '150 files is the maximum applying this code
Public i As Integer
 
Sub ABC()
 ' ----------------------------------------------------- '
' Tao cac ban VietPharse Edit                           '
' Write by:     duongthanh85                            '
' Y!M & Skype:  duongthanhhtd                           '
' Email:        duongdinhthanh@gmail.com                '
' Blog:         www.360.yahoo.com/duongthanhhtd         '
' ----------------------------------------------------- '
    
    Dim CheckFile  As Boolean
    Dim k As Integer
    Dim j As Integer
    Dim Page_hiên_tai As Integer
     
 
     'call a routine that removes all settings from the find dialog
    'so future users of the dialog won't get strange results

   ' Call ClearFindAndReplaceParameters
    
         ' Page_hiên_tai = 0
        
          'get current page
        ' Page_hiên_tai = Selection.Information(wdActiveEndAdjustedPageNumber)
         
         ' Ðánh dâu vi trí lúc Ðó
        ActiveDocument.Bookmarks.Add Range:=Selection.Range, Name:="xxxx"
        
        Selection.Find.ClearFormatting
        
        Call ClearFindAndReplaceParameters



         Call FileDialogOpen_Multi
   
         
         For j = 1 To i Step 1
         
         CheckFile = VerifyFileABC(tên_file_chon(j))
          If tên_file_chon(j) <> vbNullString And CheckFile = True Then
              'MsgBox "ok xxxxxxxxxx: " & tên_file_chon(j)
              Call trans1(tên_file_chon(j))
          
          Else
            ' Châm dut
              End
          End If
         Next
         
         ' vÊ lai trang hiên thi truoc dó
'Selection.GoTo what:=wdGoToPage, Which:=wdGoToNext, Name:=Page_hiên_tai
 
Call Xoa_hai_khoangtrang

Call ClearFindAndReplaceParameters

' Tro vê vi trí Ðánh dâu và xóa bookmark

'Application.ScreenUpdating = True
On Error Resume Next

Selection.GoTo what:=wdGoToBookmark, Name:="xxxx"

ActiveDocument.Bookmarks("xxxx").Delete

' Xoa bo nho tam
Call ClearClipboard
    
End Sub
Function VerifyFileABC(FileName As String) As Boolean
' ----------------------------------------------------- '
' Kiem tra su ton tai cua mot file                      '
' Write by:     duongthanh85                            '
' Y!M & Skype:  duongthanhhtd                           '
' Email:        duongdinhthanh@gmail.com                '
' Blog:         www.360.yahoo.com/duongthanhhtd         '
' ----------------------------------------------------- '
    On Error Resume Next
    Open FileName For Input As #1
    If Err Then
        MsgBox ("File: " & FileName & " Khong ton tai, kiem tra lai duong dan file data !! Hoac ban da huy chon file. Bon_7_THAYLUONTUEXELL_4")
        VerifyFileABC = False
    Else
        VerifyFileABC = True
    End If
    Close #1
End Function

Sub FileDialogOpen_Multi()
Dim MyDialog As FileDialog
Dim Tâp_hop_cac_tên_file As Variant
Dim KQ As Variant
 

'On Error Resume Next
Set MyDialog = Application.FileDialog(msoFileDialogFilePicker)
        With MyDialog
        .Filters.Clear
        .Filters.Add "All EXELL File ", "*.xls", 1
        .AllowMultiSelect = True
        
                 i = 1
                 If .Show = -1 Then
                    For Each Tâp_hop_cac_tên_file In .SelectedItems
                  
                    tên_file_chon(i) = Tâp_hop_cac_tên_file
                    i = i + 1
                    Next
                   i = i - 1
                    ' ReDim tên_file_chon(Tâp_hop_cac_tên_file)
                   Else
                            MsgBox "Ban chua chon file.[Bon_7_THAYLUONTUEXELL_4]"
                            End
                End If
                
        End With
End Sub

Sub trans1(txtstr As String)

' ----------------------------------------------------- '
' Thuc hien replace tu dong theo File data              '
' Write by:     duongthanh85                            '
' Y!M & Skype:  duongthanhhtd                           '
' Email:        duongdinhthanh@gmail.com                '
' Blog:         www.360.yahoo.com/duongthanhhtd         '
' ----------------------------------------------------- '
    Dim bstartApp As Boolean
    Dim xlapp As Object
    Dim xlbook As Object
    Dim xlsheet As Object
    Dim xlrange1 As Object
   
    Dim iCount As Integer
    Dim tongsotu As Integer
       
    
    Dim MyArray As Variant
    Dim Findarray As Variant
    Dim Replarray As Variant
    Dim string_Findarray() As String
    ' Thu nghiem tam thoi
    Dim KQ As String
      KQ = " "

  
   
    Dim txt_vao1 As String
    Dim txt_vao2 As String
    
    
 
     
    Dim txt_vao As String
    
  
   
    
  
    Dim i, j  As Integer
       'Khai bao Variant
    Dim Arr As Variant
     
    
    
    ' Dêm tu
    
   ' Dim NumCharsBefore As Long, NumCharsAfter As Long
   ' Dim CountWord As Long
    
     
    ' Them 1 khoang trang sau cau can xuong dong
    ' Thaymaytudongiankhongdungwildcads MÂU_TÌM:="([! ])(^13)", MÂU_THAY:="\1 \2", mau_me:=4
      
       
    
    
    
   ' Application.ScreenUpdating = False
   ' Application.ScreenUpdating = True

    'Get the number of chars in the doc BEFORE doing Find & Replace
 
    'CountWord = 0
    'NumCharsBefore = ActiveDocument.Characters.Count

    
     ' Replace theo file txt_vaostr
     
 
   
   
 




On Error Resume Next
Set xlapp = GetObject(, "Excel.Application")
If Err Then
    bstartApp = True
    Set xlapp = CreateObject("Excel.Application")
End If
'On Error GoTo 0
With xlapp
   ' On Error GoTo Err_Handler
    Set xlbook = .Workbooks.Open(txtstr)
    Set xlsheet = xlbook.Worksheets(1)
   
    
    With xlsheet
    
    ' só 4 này tuong duong voi 1 trong 4 hang sô
    ' nó tìm den dòng du lieu cuôi cùng
        Set xlrange1 = .Range("A1", .Range("A1").End(4))
       ' Set xlrange2 = .Range("B1", .Range("B1").End(4))
        Findarray = xlrange1.Value
        
      
       
        
       ' Replarray = xlrange2.Value
    End With
    
End With
If bstartApp = True Then
    xlapp.Quit
End If
Set xlapp = Nothing
Set xlbook = Nothing
Set xlsheet = Nothing
Set xlrange1 = Nothing
 
            
            For i = 1 To UBound(Findarray)
                
            
                j = InStr(Findarray(i, 1), "=")
                
                If j <> 0 Then
                                Arr = Split(Findarray(i, 1), "=", 2)
                                 txt_vao1 = Trim(Arr(0))
                                 txt_vao2 = Arr(1)
                                      If txt_vao2 = vbNullString Then
                                          txt_vao2 = " "
                                           
                                          End
                                      Else
                                              txt_vao2 = Trim(txt_vao2)
                                      End If
                          Else
                                 ' gán các giá tri này = Null se bao loi; cho chuoi bat ky
                                 txt_vao1 = "bbb111bbbccc dd dxxxyyyxzxx"
                                 txt_vao2 = "mâmmamama mmamma mamammamam"
                                 
                    
                End If
                
                
                
                   
                       ' Selection.HomeKey Unit:=wdStory
                        'iCount = 0
                        'Application.ScreenUpdating = False
           
                        With Selection.Find
                          ' .ClearFormatting
                           .MatchCase = False
                           .Text = LÂY_MÂU_TÌM(txt_vao1, txt_vao2)
                         
                                                        ''==================================
                                                        '' Kiêm tra nêu nhu có dâu * hay [ ] ( ) không thì thêm dâu \ o truoc
                                                        ''==================================
                                                        If InStr(txt_vao1, "*") <> 0 Then
                                                               txt_vao1 = Replace(txt_vao1, "*", "\*")
                                                        End If
                                                         
                                                        If InStr(txt_vao1, "[") <> 0 Then
                                                               txt_vao1 = Replace(txt_vao1, "[", "\[")
                                                        End If
                                                        
                                                        If InStr(txt_vao1, "]") <> 0 Then
                                                               txt_vao1 = Replace(txt_vao1, "]", "\]")
                                                        End If
                                                        
                                                        If InStr(txt_vao1, "(") <> 0 Then
                                                               txt_vao1 = Replace(txt_vao1, "(", "\(")
                                                        End If
                                                        If InStr(txt_vao1, ")") <> 0 Then
                                                               txt_vao1 = Replace(txt_vao1, ")", "\)")
                                                        End If
                                                        If InStr(txt_vao1, "{") <> 0 Then
                                                               txt_vao1 = Replace(txt_vao1, "{", "\{")
                                                        End If
                                                         If InStr(txt_vao1, "}") <> 0 Then
                                                               txt_vao1 = Replace(txt_vao1, "}", "\}")
                                                        End If
                                                        ' Hàm txt_vao1 nêu có dâu * se duoc bien doi
                                                        ' Luu ý là LÂY_MÂU_THAY(txt_vao1, txt_vao2) phai o tren khong thi bao loi
                                                        
                                                        
                           .Text = LÂY_MÂU_TÌM(txt_vao1, txt_vao2)
                           .Replacement.Text = LÂY_MÂU_THAY(txt_vao1, txt_vao2)
                                                   
                                                   If ((Left(Trim(txt_vao1), 1) = "|") And (Right(Trim(txt_vao1), 1) = "|")) Then
                                                    
                                                    .Text = "(^13)([ ]{1,2})(" & LÂY_MÂU_TÌM(txt_vao1, txt_vao2) & ")([ ]{1,2})(^13)"
                                                    .Replacement.Text = "\1\2" & LÂY_MÂU_THAY(txt_vao1, txt_vao2) & "\4\5"
                                                    
                                                    End If

                                 
                         
                          
                           
                                                    
                           .Replacement.HIGHLIGHT = True
                           .MatchWholeWord = True
                           .MatchWildcards = True
                                                        ''==================================
                                                        '' Kiêm tra nêu hai ve thay = nhau
                                                        ''==================================
                                                        If txt_vao1 = txt_vao2 Then
                                                               .MatchWildcards = False
                                                               .Text = "bbb111bbbccc dd dxxxyyyxzxx"
                                                               .Replacement.Text = "mâmmamama mmamma mamammamam"
                                                        End If
                                                        
                                                        
                           .MatchSoundsLike = False
                           .MatchAllWordForms = False
                           .Wrap = wdFindContinue
                      
                           
                            ' Loop until Word can no longer
                            ' find the search string and
                            ' count each instance
                                     
                                    
                                            Do While .Execute
                                                                            ''==================================
                                                                            '' Neu can dem tu thi dung icount
                                                                            'iCount = iCount + 1
                                                                            ''==================================
                                                     ' Thay 1 lân
                                                    .Execute Replace:=wdReplaceOne
                                                    ' Chuyen den tu tiep theo
                                                    Selection.MoveRight
                                                                            ''==================================
                                                                            '' Neu can dem tu thi dung icount
                                                                            'iCount = iCount + 1
                                                                            ''==================================
                                                                             'tongsotu = iCount
                                             Loop
                                     
                         End With
                                          
                              '===============Xu ly lan thu 2 cua truong hop co 2 dau "|" o dau va cuoi tu
                              
                              If ((Left(Trim(txt_vao1), 1) = "|") And (Right(Trim(txt_vao1), 1) = "|")) Then
                              
                               With Selection.Find
                                   .ClearFormatting
                                   .MatchCase = False
                                   '   mâutìm = "(^13)([ ]{1,2})(" & A_txt1_mautim & ")(^13)"
                                   ' mâutìm = "(^13)([ ]{1,2})(" & A_txt1_mautim & ")([ ]{1,2})(^13)"
                                    ' mâuthay = "\1\2" & txt2_mauthay & "\4"
                                     ' mâuthay = "\1\2" & txt2_mauthay & "\4\5"
                                  
                                   .Text = "(^13)([ ]{1,2})(" & LÂY_MÂU_TÌM(txt_vao1, txt_vao2) & ")(^13)"
                                 
                                                                ''==================================
                                                                '' Kiêm tra nêu nhu có dâu * hay [ ] ( ) không thì thêm dâu \ o truoc
                                                                ''==================================
                                                                If InStr(txt_vao1, "*") <> 0 Then
                                                                       txt_vao1 = Replace(txt_vao1, "*", "\*")
                                                                End If
                                                                 
                                                                If InStr(txt_vao1, "[") <> 0 Then
                                                                       txt_vao1 = Replace(txt_vao1, "[", "\[")
                                                                End If
                                                                
                                                                If InStr(txt_vao1, "]") <> 0 Then
                                                                       txt_vao1 = Replace(txt_vao1, "]", "\]")
                                                                End If
                                                                
                                                                If InStr(txt_vao1, "(") <> 0 Then
                                                                       txt_vao1 = Replace(txt_vao1, "(", "\(")
                                                                End If
                                                                If InStr(txt_vao1, ")") <> 0 Then
                                                                       txt_vao1 = Replace(txt_vao1, ")", "\)")
                                                                End If
                                                                If InStr(txt_vao1, "{") <> 0 Then
                                                                       txt_vao1 = Replace(txt_vao1, "{", "\{")
                                                                End If
                                                                 If InStr(txt_vao1, "}") <> 0 Then
                                                                       txt_vao1 = Replace(txt_vao1, "}", "\}")
                                                                End If
                                                                ' Hàm txt_vao1 nêu có dâu * se duoc bien doi
                                                                ' Luu ý là LÂY_MÂU_THAY(txt_vao1, txt_vao2) phai o tren khong thi bao loi
                                                                
                                                                
                                   .Text = "(^13)([ ]{1,2})(" & LÂY_MÂU_TÌM(txt_vao1, txt_vao2) & ")(^13)"
                                   .Replacement.Text = "\1\2" & LÂY_MÂU_THAY(txt_vao1, txt_vao2) & "\4"
                                              
                                                            
                                   .Replacement.HIGHLIGHT = True
                                   .MatchWholeWord = True
                                   .MatchWildcards = True
                                                                ''==================================
                                                                '' Kiêm tra nêu hai ve thay = nhau
                                                                ''==================================
                                                                If txt_vao1 = txt_vao2 Then
                                                                       .MatchWildcards = False
                                                                       .Text = "bbb111bbbccc dd dxxxyyyxzxx"
                                                                       .Replacement.Text = "mâmmamama mmamma mamammamam"
                                                                End If
                                                                
                                                                
                                   .MatchSoundsLike = False
                                   .MatchAllWordForms = False
                                   .Wrap = wdFindContinue
                                   '.Execute Replace:=wdReplaceAll
                                   ' Loop until Word can no longer
                                    ' find the search string and
                                    ' count each instance
                                     
                                    
                                            Do While .Execute
                                                                            ''==================================
                                                                            '' Neu can dem tu thi dung icount
                                                                            'iCount = iCount + 1
                                                                            ''==================================
                                                     ' Thay 1 lân
                                                    .Execute Replace:=wdReplaceOne
                                                    ' Chuyen den tu tiep theo
                                                    Selection.MoveRight
                                                                            ''==================================
                                                                            '' Neu can dem tu thi dung icount
                                                                            'iCount = iCount + 1
                                                                            ''==================================
                                                                             'tongsotu = iCount
                                             Loop
                                     
                                     
                                 End With
                            End If
                            
                            ' Neu truong hop co "|" o phia sau thi thêm 1 truong hop nua
                            
                            
                                             
                        ' Call ClearClipboard
                         
                       '  Application.ScreenUpdating = True
                       '  ActiveDocument.UndoClear
                        ' Selection.Find.ClearFormatting
                Next i
            
                                                          ' MsgBox j
                                                
                                                         '  MsgBox KQ
                                                
 
 'Get the number of chars AFTER doing Find & Replace
 'NumCharsAfter = ActiveDocument.Characters.Count

'Calculate of the number of replacements,
'and put the result into the function name variable
 'CountWord = NumCharsAfter - NumCharsBefore
 
 

 
 'Hien thi
' MsgBox "Da thay the: " & CountWord & _
                        " ky tu trong lan nay ", vbInformation
 'call a routine that removes all settings from the find dialog
'so future users of the dialog won't get strange results

'Thaymaytudongiankhongdungwildcads MÂU_TÌM:="  ", MÂU_THAY:=" ", mau_me:=5


'Err_Handler:
          '  Exit Sub

End Sub
 
Sub FileDialogOpen()
Dim item As Long
With Application.FileDialog(msoFileDialogOpen)
.AllowMultiSelect = False
.Title = "Chon file .xls de mo va thay the"
.FilterIndex = 1 '<- 1 là doc, 2 là text nhu' o' trên Ðã khai
.Show
item = .SelectedItems.Count
If item = 0 Then
selectedFilenameABC = ""
Else
selectedFilenameABC = .SelectedItems(item)
End If
End With
End Sub
Sub ClearClipboard()
  Dim oDataObject As DataObject
   Set oDataObject = New DataObject
  oDataObject.SetText ""
  oDataObject.PutInClipboard
  Set oDataObject = Nothing
End Sub
Sub ClearFindAndReplaceParameters()
        With Selection.Find
        .ClearFormatting
        .Replacement.ClearFormatting
        .Text = ""
        .Replacement.Text = ""
        .Forward = True
        .Wrap = wdFindStop
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
        End With

End Sub

Function LÂY_MÂU_TÌM(A_txt1 As String, A_txt2 As String) As String

        
    Dim A_txt1_co_dau_truoc_tu_khong As Integer
    Dim A_txt1_co_dau_sau_tu_khong As Integer
      
    
    Dim A_txt1_dau_truoc As String
    Dim A_txt1_mautim As String
    Dim A_txt1_dau_sau As String
    
    
   Dim Accc As String
   Dim Addd As String
    
   Dim Agach1, Agach2, Agach3, Akhoang_trang As String
    Dim mâutìm As String
    
    ' Các hàng sô
      Akhoang_trang = " "
      Addd = "([\\\[\],.;:\?\!\-\""\“\{\}\)\(])"
      Accc = "([\\\[\],.;:\?\!\-\""\“\{\}\)\(])"
      Agach1 = "\1"
      Agach2 = "\2"
      Agach3 = "\3"
    
      '1- Cu gán dai biên truoc da
      
      A_txt1_dau_truoc = Left(Trim(A_txt1), 1)
      A_txt1_dau_sau = Right(Trim(A_txt1), 1)
      
    '  A_txt2 = A_txt2
      
      '2-Dat biên kiêm tra xem dang truoc hay là sau co dâu hay khong
      
      ' 2a-voi A_txt1
      ' Dâu truoc
      Select Case A_txt1_dau_truoc
             Case ",", ".", ";", ":", """", "-", "'", "!", "?", "{", "}", "“"
                  ' Nêu A_txt1_dau_truoc là , . ; ' : vv thì là có = 1
                  A_txt1_co_dau_truoc_tu_khong = 1
             Case "|"
                  ' Nêu A_txt1_dau_truoc là , . ; ' : vv thì là có = 1
                  A_txt1_co_dau_truoc_tu_khong = 10
             Case Else
                  A_txt1_co_dau_truoc_tu_khong = 0
       End Select
       'Dâu sau
        Select Case A_txt1_dau_sau
             Case ",", ".", ";", ":", """", "-", "'", "!", "?", "{", "}", "“"
                  ' Nêu A_txt1_dau_sau là , . ; ' : vv thì là có = 1
                  A_txt1_co_dau_sau_tu_khong = 1
            Case "|"
                  ' Nêu A_txt1_dau_sau là , . ; ' : vv thì là có = 1
                  A_txt1_co_dau_sau_tu_khong = 10
             Case Else
                  A_txt1_co_dau_sau_tu_khong = 0
       End Select
    
         
        
        'Dinh nghia lai món .Text = A_txt1 o phía trên kia
        '3- Kiêm tra voi 4 loai phuong án cua A_txt1, roi thang A_txt2 thi an theo
            If (A_txt1_co_dau_truoc_tu_khong = 1) And (A_txt1_co_dau_sau_tu_khong = 1) Then
            
                            A_txt1_mautim = Trim(Mid(Trim(A_txt1), 2, Len(Trim(A_txt1)) - 2))
                           mâutìm = Addd & "( " & A_txt1_mautim & " )" & Accc
                         
               Else
               
                    If (A_txt1_co_dau_truoc_tu_khong = 1) And (A_txt1_co_dau_sau_tu_khong = 0) Then
                    
                                A_txt1_mautim = Trim(Mid(Trim(A_txt1), 2, Len(Trim(A_txt1)) - 1))
                                mâutìm = Addd & "( " & A_txt1_mautim & " )"
                      Else
                        If (A_txt1_co_dau_truoc_tu_khong = 0) And (A_txt1_co_dau_sau_tu_khong = 1) Then
                        
                             A_txt1_mautim = Trim(Mid(Trim(A_txt1), 1, Len(Trim(A_txt1)) - 1))
                           mâutìm = "( " & A_txt1_mautim & " )" & Accc
                         Else
                            If (A_txt1_co_dau_truoc_tu_khong = 0) And (A_txt1_co_dau_sau_tu_khong = 0) Then
             
                                 A_txt1_mautim = Trim(A_txt1)
                                mâutìm = Akhoang_trang & A_txt1_mautim & Akhoang_trang
                                
                                
                                'Bo sung them 5 truong hop co dau "|" nua
                                ' Xu ly truong hop co "|" ca truoc va sau tu thi thay the thu cong nhu tren kia
                                Else
                                        ' Co ca "|" truoc va sau tu
                                        If (A_txt1_co_dau_truoc_tu_khong = 10) And (A_txt1_co_dau_sau_tu_khong = 10) Then
                    
                                    A_txt1_mautim = Trim(Mid(Trim(A_txt1), 2, Len(Trim(A_txt1)) - 2))
                                    
                                    mâutìm = A_txt1_mautim
                                '   mâutìm = "(^13)([ ]{1,2})(" & A_txt1_mautim & ")(^13)"
                                  ' mâutìm = "(^13)([ ]{1,2})(" & A_txt1_mautim & ")([ ]{1,2})(^13)"
   ' Thaycáidâunhé MÂU_TÌM:=Chr(13) & "([ ]{1,2})(Cublic)" & Chr(13), MÂU_THAY:=Chr(13) & "\1 \2phuong an 1" & Chr(13), mau_me:=5
    ' Thaycáidâunhé MÂU_TÌM:=Chr(13) & "(Cublic)" & Chr(13), MÂU_THAY:=Chr(13) & "\1 \2phuong an 2" & Chr(13), mau_me:=5
   ' Thaycáidâunhé MÂU_TÌM:=Chr(13) & "(Cublic )" & Chr(13), MÂU_THAY:=Chr(13) & "\1 \2phuong an 3" & Chr(13), mau_me:=5
   ' Thaycáidâunhé MÂU_TÌM:=Chr(13) & "([ ]{1,2})(Cublic)([ ]{1,2})" & Chr(13), MÂU_THAY:=Chr(13) & "\1 \2 \3phuong an 4" & Chr(13), mau_me:=5
      
      '   Thaycáidâunhé MÂU_TÌM:="(lic)([ ]{1,2})" & Chr(13), MÂU_THAY:="\1 yyyy" & Chr(13), mau_me:=5
                                   Else
                                        ' Co "|" truoc con sau tu la khoang trang
                                        If (A_txt1_co_dau_truoc_tu_khong = 10) And (A_txt1_co_dau_sau_tu_khong = 0) Then
                                        
                                                    A_txt1_mautim = Trim(Mid(Trim(A_txt1), 2, Len(Trim(A_txt1)) - 1))
                                                    mâutìm = Chr(13) & "([ ]{1,2})(" & A_txt1_mautim & " )"
                                        Else
                                        ' Co "|" truoc con sau tu la co dau
                                        If (A_txt1_co_dau_truoc_tu_khong = 10) And (A_txt1_co_dau_sau_tu_khong = 1) Then
                                        
                                                    A_txt1_mautim = Trim(Mid(Trim(A_txt1), 2, Len(Trim(A_txt1)) - 2))
                                                    mâutìm = "(^13)([ ]{1,2})(" & A_txt1_mautim & ")([ ]{1,2})" & Accc
                                                    
                                                    Else
                                                        ' Khong co "|" truoc tu ma co o sau, con truoc tu la co dau ;,.
                                                        If (A_txt1_co_dau_truoc_tu_khong = 1) And (A_txt1_co_dau_sau_tu_khong = 10) Then
                                                        
                                                             A_txt1_mautim = Trim(Mid(Trim(A_txt1), 2, Len(Trim(A_txt1)) - 2))
                                                           mâutìm = Addd & "([ ]{1,2})(" & A_txt1_mautim & ")([ ]{1,2})(^13)"
                                                        
                                                        Else
                                                        ' Khong co "|" truoc tu ma co o sau, con truoc tu la khong co dau
                                                        If (A_txt1_co_dau_truoc_tu_khong = 0) And (A_txt1_co_dau_sau_tu_khong = 10) Then
                                                        
                                                             A_txt1_mautim = Trim(Mid(Trim(A_txt1), 1, Len(Trim(A_txt1)) - 1))
                                                           mâutìm = "([ ]{1,2})(" & A_txt1_mautim & ")([ ]{1,2})" & Chr(13)
                                                End If
                                            End If
                                         End If
                                       End If
                                End If
                            End If
                        End If
                      End If
               End If
               
               ' Gán hàm vào biên mautim
               LÂY_MÂU_TÌM = mâutìm
         
End Function
Function LÂY_MÂU_THAY(txt1 As String, txt2 As String) As String
 
    Dim m  As Integer
    Dim n  As Integer
    Dim txt1_co_dau_truoc_tu_khong As Integer
    Dim txt1_co_dau_sau_tu_khong As Integer
    
    Dim txt2_co_dau_truoc_tu_khong As Boolean
    Dim txt2_co_dau_sau_tu_khong As Boolean
    
    
    Dim txt1_dau_truoc As String
    Dim txt1_mautim As String
    Dim txt1_dau_sau As String
    
    Dim txt2_dau_truoc As String
    Dim txt2_mauthay As String
    Dim txt2_dau_sau As String
   
   ' Khai báo các biên moi
    Dim mâuthay As String
    Dim txt1_arr() As String
    Dim txt2_arr() As String
    Dim ttt() As String
    Dim xxx() As String
    
    Dim themtu_dau, themtu_sau As Integer
    Dim ccc, ddd, gach1, gach2, gach3, khoang_trang As String
     ' Các hàng sô
      khoang_trang = " "
      ddd = "([\\\[\],.;:\?\!\-\""\“\{\}\)\(])"
      ccc = "([\\\[\],.;:\?\!\-\""\“\{\}\)\(])"
      gach1 = "\1"
      gach2 = "\2"
      gach3 = "\3"
      
     ' Gan cai này là ""
      txt2_mauthay = ""
    
    '1 - Thu tuc xoa dâu ",", ".", ";", ":", """", "-", "'", "!", "?", "/", "[", "]", "{", "}"
    '    truoc va sau txt2 nêu có. Gia su nhu co thi cho la "" (emty)
    
    '1a- Cu gán dai biên truoc da
                                                                                           
        ' mâu thay thê
        txt2_dau_truoc = Left(Trim(txt2), 1)
        txt2_dau_sau = Right(Trim(txt2), 1)
        ' Kiem tra dau cua txt2 voi các truong hop cu the
        
           ' Dâu truoc
           Select Case txt2_dau_truoc
                  Case ",", ".", ";", ":", """", "-", "'", "!", "?", "{", "}", "“", "|"
                       ' Nêu txt2_dau_truoc là , . ; ' : vv thì là có = TRUE
                       txt2_co_dau_truoc_tu_khong = True
                  Case Else
                       txt2_co_dau_truoc_tu_khong = False
            End Select
            'Dâu sau
             Select Case txt2_dau_sau
                  Case ",", ".", ";", ":", """", "-", "'", "!", "?", "{", "}", "“", "|"
                       ' Nêu txt2_dau_sau là , . ; ' : vv thì là có = TRUE
                       txt2_co_dau_sau_tu_khong = True
                  Case Else
                       txt2_co_dau_sau_tu_khong = False
            End Select
                                                                        
            ' Cu the
                                                                        
                   If (txt2_co_dau_truoc_tu_khong = True) And (txt2_co_dau_sau_tu_khong = True) Then
        
                                    ' Dat lai txt2
                                       txt2 = Trim(Mid(Trim(txt2), 2, Len(Trim(txt2)) - 2))
                                    
                      Else
                      
                           If (txt2_co_dau_truoc_tu_khong = True) And (txt2_co_dau_sau_tu_khong = False) Then
                           
                                    ' Dat lai txt2
                                       txt2 = Trim(Mid(Trim(txt2), 2, Len(Trim(txt2)) - 1))
                                        
                             Else
                               If (txt2_co_dau_truoc_tu_khong = False) And (txt2_co_dau_sau_tu_khong = True) Then
                                  
                                    ' Dat lai txt2
                                      txt2 = Trim(Mid(Trim(txt2), 1, Len(Trim(txt2)) - 1))
                                    
                                Else
                                   If (txt2_co_dau_truoc_tu_khong = False) And (txt2_co_dau_sau_tu_khong = False) Then
                                       ' Dat lai txt2
                                        txt2 = Trim(txt2)
                                        
                                   End If
                               End If
                             End If
                      End If
                      
  '2- Gán giá tri mang cho txt1_arr,txt2_arr túc là khai báo dang mang ARRAY
    txt2 = txt2
    
   ' If (InStr(txt1, " ") <> 0 And InStr(txt2, " ") <> 0) Then
    
    txt1_arr() = Split(Trim(txt1), " ")
    txt2_arr() = Split(Trim(txt2), " ") ' Lúc này thì txt2 không còn dâu sau hay truoc nua, do dã xu lý o tren muc 1 rôi
          ' Nho phai có dâu () sau txt1_arr,txt2_arr dê nó hiêu là mang ARRAY

        ' 2a-voi txt1
         ' 2a-voi txt1
          
          ' Dâu truoc
    If txt1_arr(0) <> Empty Then
          Select Case txt1_arr(0)
                 Case ",", ".", ";", ":", """", "-", "'", "!", "?", "{", "}", """"
                      ' Nêu txt1_dau_truoc là , . ; ' : vv thì là có = 1
                      txt1_co_dau_truoc_tu_khong = 1
                 Case "|"
                      ' Nêu txt1_dau_truoc là | thì là có = 10
                      txt1_co_dau_truoc_tu_khong = 10
                 Case Else
                      txt1_co_dau_truoc_tu_khong = 0
           End Select
    End If
           'Dâu sau
    If txt1_arr(UBound(txt1_arr)) <> Empty Then
            Select Case txt1_arr(UBound(txt1_arr))
                 Case ",", ".", ";", ":", """", "-", "'", "!", "?", "{", "}", """"
                      ' Nêu txt1_dau_sau là , . ; ' : vv thì là có = 1
                      txt1_co_dau_sau_tu_khong = 1
                 Case "|"
                      ' Nêu txt1_dau_sau là | thì là có = 10
                      txt1_co_dau_sau_tu_khong = 10
                 Case Else
                      txt1_co_dau_sau_tu_khong = 0
           End Select
    End If
           
 
        'Rât quan trong dây nhé
        '2b-voi txt2_arr(o)
           ' Phân tu so 1
           
        ' Kiêm tra neu nhu txt2 khac chuoi " " thì moi thi hanh lenh nay, neu không thì không doc ma lenh này dê tránh lôi, chua thu cac
        ' dong ma voi truong hop la chuoi " "
        If Trim(txt2) <> "" Then
           
                If txt2_arr(0) <> Empty Then
                 
                          Select Case txt2_arr(0)
                                Case "+1", "1+", "+1+", "+01", "01+", "+01+", "01", "1"
                                     ' Thì thêm 1 tu [dau cong]
                                     themtu_dau = 10
                                Case "*1", "1*", "*1*", "*01", "01*", "*01*", "*"
                                     ' Thì thêm 1 tu [dau *]
                                     themtu_dau = 1
                                Case "+2", "2+", "+2+", "+02", "02+", "+02+", "02", "2"
                                     ' Thì thêm 2 tu [dau cong]
                                     themtu_dau = 20
                                Case "*2", "2*", "*2*", "*02", "02*", "*02*"
                                     ' Thì thêm 2 tu [dau *]
                                     themtu_dau = 2
                                Case "+3", "3+", "+3+", "+03", "03+", "+03+", "03", "3"
                                     ' Thì thêm 3 tu [dau cong]
                                     themtu_dau = 30
                                Case "*3", "3*", "*3*", "*03", "03*", "*03*"
                                     ' Thì thêm 3 tu [dau *]
                                     themtu_dau = 3
                                Case Else
                                     themtu_dau = 0
                          End Select
                          
                         
                   End If
            'Phân tu so 2
            
                If txt2_arr(UBound(txt2_arr)) <> Empty Then
                         Select Case txt2_arr(UBound(txt2_arr))
                                Case "+1", "1+", "+1+", "+01", "01+", "+01+", "01", "1"
                                    ' Thì thêm 1 tu [dau cong]
                                    themtu_sau = 10
                               Case "*1", "1*", "*1*", "*01", "01*", "*01*", "*"
                                    ' Thì thêm 1 tu [dau *]
                                    themtu_sau = 1
                               Case "+2", "2+", "+2+", "+02", "02+", "+02+", "02", "2"
                                    ' Thì thêm 2 tu [dau cong]
                                    themtu_sau = 20
                               Case "*2", "2*", "*2*", "*02", "02*", "*02*"
                                    ' Thì thêm 2 tu [dau *]
                                    themtu_sau = 2
                               Case "+3", "3+", "+3+", "+03", "03+", "+03+", "03", "3"
                                    ' Thì thêm 3 tu [dau cong]
                                    themtu_sau = 30
                               Case "*3", "3*", "*3*", "*03", "03*", "*03*"
                                    ' Thì thêm 3 tu [dau *]
                                    themtu_sau = 3
                               Case Else
                                    themtu_sau = 0
                         End Select
                     
                 End If
    End If
    
    
    
' Cac truong hop xay ra cua tu truoc.
' Neu nhu có dâu truoc tu txt1 thì bo qua anh huong txt1_arr(0) noi txt2_arr(0)

    If txt1_co_dau_truoc_tu_khong = 0 Then
                   
                    If themtu_dau = 10 Then
                             
                            txt2_arr(0) = txt1_arr(0) & " +"
                    Else
                         If themtu_dau = 1 Then
                           
                               txt2_arr(0) = txt1_arr(0) & " *"
                         Else
                              If themtu_dau = 20 Then
                                           If (UBound(txt1_arr) + 1) = 1 Then
                                                'Nhay den *///* - tuc la khong lam ji ca
                                                ' Coi nhu nhap sai so
                                              Else
                                                  If (UBound(txt1_arr) + 1) = 2 Then
                                                     txt2_arr(0) = txt1_arr(0) & " " & txt1_arr(1) & " +"
                                                  Else
                                                        txt2_arr(0) = txt1_arr(0) & " " & txt1_arr(1) & " +"
                                                   End If
                                            End If
                                     
                               Else
                                    If themtu_dau = 2 Then
                                        If (UBound(txt1_arr) + 1) = 1 Then
                                                'Nhay den *///* - tuc la khong lam ji ca
                                                ' Coi nhu nhap sai so
                                              Else
                                                  If (UBound(txt1_arr) + 1) = 2 Then
                                                     txt2_arr(0) = txt1_arr(0) & " " & txt1_arr(1) & " *"
                                                  Else
                                                     txt2_arr(0) = txt1_arr(0) & " " & txt1_arr(1) & " *"
                                                   End If
                                            End If
                                    Else
                                        If themtu_dau = 30 Then
                                          If (UBound(txt1_arr) + 1) = 1 Then
                                                'Nhay den *///* - tuc la khong lam ji ca
                                                ' Coi nhu nhap sai so
                                                Else
                                                    If (UBound(txt1_arr) + 1) = 2 Then
                                                       'Nhay den *///* - tuc la khong lam ji ca
                                                       ' Coi nhu nhap sai so
                                                        Else
                                                            If (UBound(txt1_arr) + 1) = 3 Then
                                                               txt2_arr(0) = txt1_arr(0) & " " & txt1_arr(1) & " " & txt1_arr(2) & " +"
                                                             Else
                                                                txt2_arr(0) = txt1_arr(0) & " " & txt1_arr(1) & " " & txt1_arr(2) & " +"
                                                            
                                                            End If
                                                    End If
                                            End If
                                           
                                        Else
                                             If themtu_dau = 3 Then
                                                If (UBound(txt1_arr) + 1) = 1 Then
                                                'Nhay den *///* - tuc la khong lam ji ca
                                                ' Coi nhu nhap sai so
                                                Else
                                                    If (UBound(txt1_arr) + 1) = 2 Then
                                                       'Nhay den *///* - tuc la khong lam ji ca
                                                       ' Coi nhu nhap sai so
                                                        Else
                                                            If (UBound(txt1_arr) + 1) = 3 Then
                                                               txt2_arr(0) = txt1_arr(0) & " " & txt1_arr(1) & " " & txt1_arr(2) & " *"
                                                             Else
                                                                ' Nhay den *///*
                                                                ' Coi nhu nhap sai so
                                                             End If
                                                    End If
                                              End If
                                            Else
                                               ' Dieu kien là *///* Dieu kiên cuôi cung la o dây, tât ca nhay vao dây
                                            End If
                                        End If
                                    End If
                              End If
                        End If
                    End If
              
      End If
 
   ' Cac truong hop xay ra cua tu sau

    If txt1_co_dau_sau_tu_khong = 0 Then
    
         If themtu_sau = 10 Then
                   txt2_arr(UBound(txt2_arr)) = "+ " & txt1_arr(UBound(txt1_arr))
                    Else
                         If themtu_sau = 1 Then
                            txt2_arr(UBound(txt2_arr)) = "* " & txt1_arr(UBound(txt1_arr))
                         Else
                              If (themtu_sau = 20 And themtu_sau <= (UBound(txt1_arr) + 1) * 10) Then
                               
                               txt2_arr(UBound(txt2_arr)) = "+ " & txt1_arr(UBound(txt1_arr) - 1) & " " & txt1_arr(UBound(txt1_arr))
                               
                               Else
                                    If (themtu_sau = 2 And themtu_sau <= (UBound(txt1_arr) + 1)) Then
                                         txt2_arr(UBound(txt2_arr)) = "* " & txt1_arr(UBound(txt1_arr) - 1) & " " & txt1_arr(UBound(txt1_arr))
                                    Else
                                        If (themtu_sau = 30 And themtu_sau <= (UBound(txt1_arr) + 1) * 10) Then
                                            txt2_arr(UBound(txt2_arr)) = "+ " & txt1_arr(UBound(txt1_arr) - 2) & " " & _
                                                                                txt1_arr(UBound(txt1_arr) - 1) & " " & _
                                                                                txt1_arr(UBound(txt1_arr))
                                        Else
                                            If (themtu_sau = 3 And themtu_sau <= (UBound(txt1_arr) + 1)) Then
                                            txt2_arr(UBound(txt2_arr)) = "* " & txt1_arr(UBound(txt1_arr) - 2) & " " & _
                                                                                txt1_arr(UBound(txt1_arr) - 1) & " " & _
                                                                                txt1_arr(UBound(txt1_arr))
                                                
                                            Else
                                                     
                                            End If
                                        End If
                                    End If
                              End If
                        End If
                    End If

      End If
 
                  
            
    '3- Kiêm tra voi 4 loai phuong án cua txt2, tuong ung voi txt1
        ' - muc 3.1
        
        If (txt1_co_dau_truoc_tu_khong = 1) And (txt1_co_dau_sau_tu_khong = 1) Then
        
                   ' Kiêm tra xem dau truoc và dâu sau cua txt2 co vào dung hay không so voi quy dinh
                   ' Nêu co dau thi bo cac dau này di, thay vào do là dùng \1 cho dâu dâu
                                                                        '  \3 cho dâu cuôi mâu doan van
                   ' Cái này là chung cho các mâu if o duoi day, chi khac nhau o phân .Replacement.Text
                                                                        
                    For m = 0 To UBound(txt2_arr)
                     
                           If txt2_arr(m) <> Empty Then
                                 ' Noi chuoi lai voi nha
                                 
                                 txt2_mauthay = txt2_mauthay & txt2_arr(m) & " "
                                 
                            End If
                    Next m
                 
                    
                    txt2_mauthay = Trim(txt2_mauthay)
            
                    mâuthay = gach1 & " " & txt2_mauthay & " " & gach3
                     
           Else
                ' - muc 3.2
                If (txt1_co_dau_truoc_tu_khong = 1) And (txt1_co_dau_sau_tu_khong = 0) Then
                       ' Kiêm tra xem dau truoc và dâu sau cua txt2 co vào dung hay không so voi quy dinh
                       ' Nêu co dau thi bo cac dau này di, thay vào do là dùng \1 cho dâu dâu
                                                                            '  \3 cho dâu cuôi mâu doan van
                       ' Cái này là chung cho các mâu if o duoi day, chi khac nhau o phân .Replacement.Text
                                                                            
                       
                        ' Mâu thay thê se duoc sua dôi moi lai nhu sau trong ô .Replacement.Text
                          
                          For m = 0 To UBound(txt2_arr)
                     
                            If txt2_arr(m) <> Empty Then
                                  ' Noi chuoi lai voi nha
                                  
                                  txt2_mauthay = txt2_mauthay & txt2_arr(m) & " "
                                  
                             End If
                         Next m
                 
                    
                           txt2_mauthay = Trim(txt2_mauthay)
                        
                           mâuthay = gach1 & " " & txt2_mauthay & khoang_trang
                           
                  Else
                    ' - muc 3.3
                    If (txt1_co_dau_truoc_tu_khong = 0) And (txt1_co_dau_sau_tu_khong = 1) Then
                    
                       ' Kiêm tra xem dau truoc và dâu sau cua txt2 co vào dung hay không so voi quy dinh
                       ' Nêu co dau thi bo cac dau này di, thay vào do là dùng \1 cho dâu dâu
                                                                            '  \3 cho dâu cuôi mâu doan van
                       ' Cái này là chung cho các mâu if o duoi day, chi khac nhau o phân .Replacement.Text
                                                                            
                       
                        ' Mâu thay thê se duoc sua dôi moi lai nhu sau trong ô .Replacement.Text
                            For m = 0 To UBound(txt2_arr)
                        
                               If txt2_arr(m) <> Empty Then
                                     ' Noi chuoi lai voi nha
                                     
                                     txt2_mauthay = txt2_mauthay & txt2_arr(m) & " "
                                     
                                End If
                            Next m
                    
                    
                           txt2_mauthay = Trim(txt2_mauthay)
                           mâuthay = khoang_trang & txt2_mauthay & " " & gach2
                           
                     Else
                     
                        ' - muc 3.4
                        If (txt1_co_dau_truoc_tu_khong = 0) And (txt1_co_dau_sau_tu_khong = 0) Then
         
                           ' Kiêm tra xem dau truoc và dâu sau cua txt2 co vào dung hay không so voi quy dinh
                           ' Nêu co dau thi bo cac dau này di, thay vào do là dùng \1 cho dâu dâu
                                                                                '  \3 cho dâu cuôi mâu doan van
                           ' Cái này là chung cho các mâu if o duoi day, chi khac nhau o phân .Replacement.Text
                                                                                
                                                                                
                           
                            ' Mâu thay thê se duoc sua dôi moi lai nhu sau trong ô .Replacement.Text
                                    For m = 0 To UBound(txt2_arr)
                            
                                     If txt2_arr(m) <> Empty Then
                                         ' Noi chuoi lai voi nha
                                         
                                         txt2_mauthay = txt2_mauthay & txt2_arr(m) & " "
                                         
                                      End If
                                     Next m
                 
                    
                                    txt2_mauthay = Trim(txt2_mauthay)
                                    mâuthay = khoang_trang & txt2_mauthay & khoang_trang
                                    
    
    '==============================================================
    '* Phân nay kiêm tra va them sau voi 5 loai phuong án cua txt2
    '  khi co dau "|", tuong ung voi txt1
    '  duoc bo sung sau nay
    '  Neu nhu chay khong chuan co the xoa tu khuc nay
    '  Quy uoc txt1_co_dau_truoc_tu_khong = 1 va txt1_co_dau_truoc_tu_khong = 10
    '          txt1_co_dau_sau_tu_khong = 1 va txt1_co_dau_sau_tu_khong = 10
    ' tuc la co 2 truong hop nhu vay
    '==============================================================
        
        Else
                If (txt1_co_dau_truoc_tu_khong = 10) And (txt1_co_dau_sau_tu_khong = 10) Then
        
                   ' Kiêm tra xem dau truoc và dâu sau cua txt2 co vào dung hay không so voi quy dinh
                   ' Nêu co dau thi bo cac dau này di, thay vào do là dùng \1 cho dâu dâu
                                                                        '  \3 cho dâu cuôi mâu doan van
                   ' Cái này là chung cho các mâu if o duoi day, chi khac nhau o phân .Replacement.Text
                   
                   ' muc (a)
                    For m = 0 To UBound(txt2_arr)
                     
                           If txt2_arr(m) <> Empty Then
                                 ' Noi chuoi lai voi nha
                                 
                                 txt2_mauthay = txt2_mauthay & txt2_arr(m) & " "
                                 
                            End If
                    Next m
                 
                    
                    txt2_mauthay = Trim(txt2_mauthay)
                       
                       
                     mâuthay = txt2_mauthay
                   
                   ' mâuthay = "\1\2" & txt2_mauthay & "\4"
                    ' mâuthay = "\1\2" & txt2_mauthay & "\4\5"
                    
                                    
                Else
                       If (txt1_co_dau_truoc_tu_khong = 10) And (txt1_co_dau_sau_tu_khong = 1) Then
                          ' Nhu muc (a) tren
                          ' chi khac la co cai duoi
                          ' muc (b)
                          '  mâutìm = "(^13)([ ]{1,2})(" & A_txt1_mautim & ")([ ]{1,2})" & Accc
                          For m = 0 To UBound(txt2_arr)
                         
                               If txt2_arr(m) <> Empty Then
                                     ' Noi chuoi lai voi nha
                                     
                                     txt2_mauthay = txt2_mauthay & txt2_arr(m) & " "
                                     
                                End If
                        Next m
                     
                        
                        txt2_mauthay = Trim(txt2_mauthay)
                
                        mâuthay = "\1\2" & txt2_mauthay & "\4\5"
                                 
                    Else
                           If (txt1_co_dau_truoc_tu_khong = 10) And (txt1_co_dau_sau_tu_khong = 0) Then
                              ' Nhu muc (3.2) tren
                              ' muc (c)
                              
                              For m = 0 To UBound(txt2_arr)
                        
                               If txt2_arr(m) <> Empty Then
                                     ' Noi chuoi lai voi nha
                                     
                                     txt2_mauthay = txt2_mauthay & txt2_arr(m) & " "
                                     
                                End If
                            Next m
                    
                       
                              txt2_mauthay = Trim(txt2_mauthay)
                           
                              mâuthay = Chr(13) & "\1" & txt2_mauthay & khoang_trang
                              
                         Else
                              ' Nhu muc (3.3) tren
                              ' muc (d)
                            If (txt1_co_dau_truoc_tu_khong = 0) And (txt1_co_dau_sau_tu_khong = 10) Then
                             
                                ' Kiêm tra xem dau truoc và dâu sau cua txt2 co vào dung hay không so voi quy dinh
                                ' Nêu co dau thi bo cac dau này di, thay vào do là dùng \1 cho dâu dâu
                                                                                     '  \3 cho dâu cuôi mâu doan van
                                ' Cái này là chung cho các mâu if o duoi day, chi khac nhau o phân .Replacement.Text
                                                                                     
                                
                                 ' Mâu thay thê se duoc sua dôi moi lai nhu sau trong ô .Replacement.Text
                                     For m = 0 To UBound(txt2_arr)
                                 
                                        If txt2_arr(m) <> Empty Then
                                              ' Noi chuoi lai voi nha
                                              
                                              txt2_mauthay = txt2_mauthay & txt2_arr(m) & " "
                                              
                                         End If
                                     Next m
                             
                             
                                    txt2_mauthay = Trim(txt2_mauthay)
                                    mâuthay = "\1" & txt2_mauthay & "\3" & Chr(13)
                                   
                                    
                            Else
                              ' Nhu muc (3.1) tren
                              ' muc (e)
                               If (txt1_co_dau_truoc_tu_khong = 1) And (txt1_co_dau_sau_tu_khong = 10) Then
                               For m = 0 To UBound(txt2_arr)
                     
                                If txt2_arr(m) <> Empty Then
                                      ' Noi chuoi lai voi nha
                                      
                                      txt2_mauthay = txt2_mauthay & txt2_arr(m) & " "
                                 
                                End If
                                        Next m
                                     
                                        
                                        txt2_mauthay = Trim(txt2_mauthay)
                                
                                        mâuthay = "\1\2" & txt2_mauthay & "\4\5"
                                    
                           End If
                        End If
                    End If
                  End If
                            End If
                        End If
                    End If
                  End If
           End If
             
             
                                                           
  

        ' Gán hàm vào biên mâuthay
         LÂY_MÂU_THAY = mâuthay

End Function

 Public Sub SearchAndReplaceInStory_EXELL(ByVal strSearch As Variant, ByVal strReplace As Variant)
    Dim iCount As Integer
        With Selection.Find
                                         
           .MatchCase = False
           .Text = strSearch
           .Replacement.Text = strReplace
           .Replacement.HIGHLIGHT = True
           .MatchWholeWord = True
           .MatchWildcards = True
           .MatchSoundsLike = False
           .MatchAllWordForms = False
           .Wrap = wdFindContinue
           .Execute Replace:=wdReplaceAll
           
    End With
End Sub
Private Sub Tìm_va_thay_ngay_tung_tu_môt()

With Selection.Find
   .Execute Replace:=wdReplaceOne
 
    While .Found
       .Execute Replace:=wdReplaceOne
    Wend
 End With
 End Sub
 Private Sub Thaymaytudongiankhongdungwildcads(MÂU_TÌM As String, MÂU_THAY As String, _
                                             Optional ByVal Loai As Integer = 0, Optional ByVal mau_me As Integer = 4)
    On Error Resume Next
    With Selection.Find
        .ClearFormatting
        .Replacement.ClearFormatting
        Select Case Loai
           Case 0:
           Case 1: .Replacement.Font.Italic = True 'italic
           Case 2: Selection.Find.MatchCase = True ' Hoa
           Case 3: Selection.Find.MatchCase = True '-> thuong
                    Selection.Find.Replacement.Font.Italic = False
                    Selection.Find.Replacement.Font.Color = wdColorAutomatic
        End Select
        Select Case mau_me
           Case 4:  .Replacement.HIGHLIGHT = False
           Case 5:     .Replacement.HIGHLIGHT = True
            
        End Select
        .MatchWildcards = False
        .MatchWildcards = False
         
        .Text = MÂU_TÌM
        .Replacement.Text = MÂU_THAY
        '.Execute Replace:=wdReplaceAll
        .Execute Replace:=wdReplaceOne
 
                    While .Found
                       .Execute Replace:=wdReplaceOne
                    Wend
        ' phuc hôi cho lâ`n tiêp default
       .ClearFormatting
        .Replacement.ClearFormatting
        .Forward = True
        .Wrap = wdFindContinue
        .MatchCase = False
        '.Replacement.Font.Italic = False
       '.Replacement.Font.Bold = False
       '.Replacement.Font.Color = 0
       
    End With
End Sub
Private Sub Xoa_hai_khoangtrang()

    With Selection.Find
                           .ClearFormatting
                           .MatchCase = False
                                                        
                           .Text = "  "
                           .Replacement.Text = " "
                           .Replacement.HIGHLIGHT = True
                           .MatchWholeWord = True
                           .MatchWildcards = True
                           .MatchSoundsLike = False
                           .MatchAllWordForms = False
                           .Wrap = wdFindContinue
                      
                           
                            ' Loop until Word can no longer
                            ' find the search string and
                            ' count each instance
                                     
               
                       Do While .Execute
                                                        
                               .Execute Replace:=wdReplaceOne
                               ' Chuyen den tu tiep theo
                               Selection.MoveRight
                                                       
                        Loop
                
    End With
End Sub
Sub Thu_Nghiem()
    Dim t_t As String
    Dim s_s As String
    Dim vvv As String
    Dim yyy As String
  
    Dim mmm  As String
    Dim NNN  As String
    'Dim txt1_arr() As String
    
    
                     
     
             mmm = " | Papa your ,"
 
  
            NNN = " fdgsdfgsdfg "
 
     ' txt1_arr() = Split(Trim(mmm), " ")
     ' MsgBox "LÂY_GÍA_TRI_CUA_txt1: " & txt1_arr(0), vbInformation
   '  MsgBox "LÂY_GÍA_TRI_CUA_txt1: " & txt1_arr(1), vbInformation
                     ' If InStr(mmm, "*") Then
                       '  vvv = Replace(mmm, "*", "\*")
                       '  Else
                        ' vvv = mmm
                       ' End If
                     '
      
  
            ' Cai nay giu lai ma thu nghiem
            t_t = LÂY_MÂU_TÌM(mmm, NNN)
            s_s = LÂY_MÂU_THAY(mmm, NNN)
            MsgBox "LÂY_GÍA_TRI_CUA_txt1: " & t_t, vbInformation
            MsgBox "LÂY_GÍA_TRI_CUA_txt2: " & s_s, vbInformation
           'MsgBox "VD: " & Chr(13) & "([ ]{1,2})" & t_t & Chr(13)
End Sub
Đầu trang
anhcau
Bài viết: 8
Ngày tham gia: Thứ 7 06/07/2013 1:18 pm
Ứng dụng dịch Tiếng Anh và một số ngoại ngữ trong MS Word
Gửi bài by anhcau » Thứ 5 22/01/2015 12:08 pm

2-CÁCH HOẠT ĐỘNG CỦA PHẦN MÃ NÀY

Cơ sở:

a- Trong đoạn văn A nói trên, các bạn thấy mấy từ đứng trong câu tôi tạm trích như sau:
"My children, that it is not for your physical well-being I come.
I will speak most profoundly in a Christmas message to all My children. Tonight, I am blessing you with My Blessing of Holy Love.
... in this regard. My children, I love you, I pray for ...
Tôi muốn thay đơn giản là chữ My children, ở đây là khá dễ, nếu thay đằng sau và trước từ đó không có khoảng trắng đi kèm, nghĩa là thế nào. Xin xét ví dụ sau đây:

Bản văn B:

Such a soul could easily lose his way because he does not look within himself but looks outside himself seeking perfection, seeking more exterior grace.

... Let Holy Love chart the course of all souls for it is in this way harmony is restored in the universe.

Bản văn C:

Some of these hearts have been laid waste by compromise and error, and misrepresent the faith.
For it is in this way the world will undergo a genesis and be renewed in the Faith.
.. now for all the faithful departed.


Bạn để ý rằng, nếu thay cụm từ My children trong Bản văn A không cần dùng hai khoảng trắng trước và sau từ này vẫn đúng thì trong các trường hợp khác lại không áp dụng được. Thí dụ trong ví dụ bản văn B, nếu thay từ his way = lối của anh ta thì nó sẽ như sau:

Bản văn B:

Such a soul could easily lose lối của anh ta because he does not look within himself but looks outside himself seeking perfection, seeking more exterior grace.

... Let Holy Love chart the course of all souls for it is in tlối của anh ta harmony is restored in the universe.

còn với bản văn C thì khi thay the faith = những người thành tín thì nó trở thành như sau

Bản văn C:

Some of these hearts have been laid waste by compromise and error, and misrepresent những người thành tín.
For it is in this way the world will undergo a genesis and be renewed in the Faith.
.. now for all những người thành tínful departed.


Như thế, các từ ở trên có vấn đề là các từ này:
tlối của anh ta
những người thành tínful
Trong nhiều trường hợp ta không còn biết được từ nguyên gốc tiếng Anh ban đầu như thế nào nữa, thì lại rất tệ hại!

Vì thay thế hàng loạt nên chắc chắn rằng phải thay thế dạng có dấu khoảng trắng trước và sau từ cần thay, có nghĩa là, các từ thay sẽ có dạng:
_My children_ = các con của Tôi
_his way_ = lối của anh ta
_the faith_ = những người thành tín
Trong đó, để dế nhìn tôi mô phỏng các khoảng trắng " " bằng ký tự _
Để ý rằng việc Replace trong MS Word 2003 không thay thế được các từ (đã được chia thành quá khứ phân từ, hay dạng -ed ... ) nếu nó là 2 từ trở lên được thay thế cùng lúc.

Như thế lại phát sinh vấn đề là tại đoạn văn A, từ My children lại có các dấu đằng trước và đằng sau đi kèm như dưới đây:
"My children, that it is not for your physical well-being I come.
I will speak most profoundly in a Christmas message to all My children. Tonight, I am blessing you with My Blessing of Holy Love.
... in this regard. My children, I love you, I pray for ...
Trong khi dạng thay thế được phải là:
" My children , that it is not for your physical well-being I come.
I will speak most profoundly in a Christmas message to all My children . Tonight, I am blessing you with My Blessing of Holy Love.
... in this regard. My children , I love you, I pray for ...
(Để ý rằng các dấu đã không còn dính liền với các ký tự cuối cùng và phía đầu tiên của từ nữa)

*Chú ý:
Vẫn thay thế được với các dấu liền kề các chữ đính kèm trước và sau từ cần thay, tuy nhiên vì tổ hợp dấu khá nhiều, bao gồm các dấu:
.
,
;
:
-
!
?
"
nên sẽ gây ra trường hợp là máy xử lý chậm chạp hơn so với khi có hai khoảng trắng hai phía, cái này tôi đã thử! Nên trường hợp tôi nói ở đây là không tính đến trường hợp này nữa.

Ngoài ra khi thay thế như thế thì do có hai khoảng trắng ở đầu nên từ đầu câu cũng phải lui vào ít nhất là một khoảng trắng, và các từ cuối của đoạn văn hay câu văn, nếu không có các dấu , . ; " : ! ? / { } [ ] ( ) cũng phải có thêm ít ra là một khoảng trắng nữa mới có thể thay được hết.

Các câu có Bullets hay Numbering ở đầu cũng tương tự.
Sửa lần cuối bởi 1 vào ngày anhcau với 0 lần sửa trong tổng số.
Đầu trang
anhcau
Bài viết: 8
Ngày tham gia: Thứ 7 06/07/2013 1:18 pm
Ứng dụng dịch Tiếng Anh và một số ngoại ngữ trong MS Word
Gửi bài by anhcau » Thứ 5 22/01/2015 12:18 pm

b - Giải pháp tạo khoảng trắng trước và sau từ.

Dùng mã Macro (ký hiệu MA2) đơn giản sau đây:

MÃ: CHỌN TẤT CẢ

Public Sub Thaycáidâunhé(MÂU_TÌM As String, MÂU_THAY As String, _
                                             Optional ByVal Loai As Integer = 0, Optional ByVal mau_me As Integer = 4)
    On Error Resume Next
    With Selection.Find
        .ClearFormatting
        .Replacement.ClearFormatting
        Select Case Loai
           Case 0:
           Case 1: .Replacement.Font.Italic = True 'italic
           Case 2: Selection.Find.MatchCase = True ' Hoa
           Case 3: Selection.Find.MatchCase = True '-> thuong
                    Selection.Find.Replacement.Font.Italic = False
                    Selection.Find.Replacement.Font.Color = wdColorAutomatic
        End Select
        Select Case mau_me
           Case 4:  .Replacement.HIGHLIGHT = False
           Case 5:     .Replacement.HIGHLIGHT = True
            
        End Select
        .MatchWildcards = False
        .MatchWildcards = True
        
        .Text = MÂU_TÌM
        .Replacement.Text = MÂU_THAY
        .Execute Replace:=wdReplaceAll
         
                   
        
        
        ' phuc hôi cho lâ`n tiêp default
       .ClearFormatting
        .Replacement.ClearFormatting
        .Forward = True
        .Wrap = wdFindContinue
        .MatchCase = False
         
       
       
                     
    End With
End Sub
Private Sub Dichvaomotkytuodaucau()
Selection.HomeKey Unit:=wdStory, Extend:=wdMove ' vê` Ðâ`u document
Do Until Selection.Range.Bookmarks.Exists("\EndOfDoc") = True ' cho Ðê'n cuô'i document
  Selection.Move wdSentence, 1 ' move tu'`ng câu
   Selection.MoveRight wdCharacter, 1, wdExtend ' chon ký tu Ðâu câu
   Selection.Text = " " & (Selection.Text)
Loop ' Vòng lap
End Sub
Sub Thay_thê_dâu_Moinhe()
     
     
     Dim DÂU As String
       
      ' Ðánh dâu vi trí lúc Ðó
        ActiveDocument.Bookmarks.Add Range:=Selection.Range, Name:="xxxx"

    
    ' Các hàng sô
      
      DÂU = "([\\\[\],.;:\?\!\""\“\{\}\)\(])"
       
       ' Xu ly dâu dung vao vi tri
         
       Thaycáidâunhé MÂU_TÌM:=DÂU, MÂU_THAY:="\1 ", mau_me:=4
       
       ' Dich vao 1 ky tu o dau cau
       ' Cho cac tu o dâu câu thut vao 1 khoang trang
       Call Dichvaomotkytuodaucau
              
      ' Them 1 khoang trang sau cau can xuong dong
       Thaycáidâunhé MÂU_TÌM:="([! ])(^13)", MÂU_THAY:="\1 \2", mau_me:=4
       
       ' Xoa cac khoang trang
       Thaycáidâunhé MÂU_TÌM:="([ ]{2,10})", MÂU_THAY:=" ", mau_me:=4
      
      ' Cho cac tu o dâu câu thut vao 1 khoang trang
      ' Thaycáidâunhé MÂU_TÌM:="((chr(13))" & "([! ])", MÂU_THAY:=" \1\2", mau_me:=5
       
   
       Thaycáidâunhé MÂU_TÌM:="([! ])" & DÂU & DÂU, MÂU_THAY:="\1 \2 \3", mau_me:=4
       
       Thaycáidâunhé MÂU_TÌM:="([! ])" & DÂU & Chr(32), MÂU_THAY:="\1 \2 ", mau_me:=4
       
       Thaycáidâunhé MÂU_TÌM:="([ ])" & DÂU & "([! ])", MÂU_THAY:="\1 \2 \3", mau_me:=4
       
       Thaycáidâunhé MÂU_TÌM:=DÂU, MÂU_THAY:="\1", mau_me:=5
       
       Thaycáidâunhé MÂU_TÌM:=DÂU & DÂU, MÂU_THAY:="\1 \2", mau_me:=5
      ' Xoa cac khoang trang
      ' lam lai them lan nua
      
       Thaycáidâunhé MÂU_TÌM:="([ ]{2,10})", MÂU_THAY:=" ", mau_me:=4
        
          Thaycáidâunhé MÂU_TÌM:="([ ]{2,10})", MÂU_THAY:=" ", mau_me:=4
          
    ' Thay cac chu a . m va p . m thanh a.m p.m
     
            Thaycáidâunhé MÂU_TÌM:="([ a])([ ])([,.;:])([ ])([m ])", MÂU_THAY:="\1\3\5", mau_me:=4
            Thaycáidâunhé MÂU_TÌM:="([ A])([ ])([,.;:])([ ])([m ])", MÂU_THAY:="\1\3\5", mau_me:=4
            Thaycáidâunhé MÂU_TÌM:="([ p])([ ])([,.;:])([ ])([m ])", MÂU_THAY:="\1\3\5", mau_me:=4
            Thaycáidâunhé MÂU_TÌM:="([ P])([ ])([,.;:])([ ])([m ])", MÂU_THAY:="\1\3\5", mau_me:=4
    
    ' phuc hoi cac dau : o giua các sô
            
      Thaycáidâunhé MÂU_TÌM:="([0-9]{1,2})([ ])([,.;:])([ ])([0-9]{1,2})", MÂU_THAY:="\1\3\5", mau_me:=4
            
         
           
        'Thaycáidâunhé MÂU_TÌM:="([ ]{1,2})(Fatima)" & Chr(13), MÂU_THAY:="\1 \2 phuong an 1" & Chr(13), mau_me:=5
       ' Thaycáidâunhé MÂU_TÌM:="(Fatima)" & Chr(13), MÂU_THAY:="\1 \2phuong an 2" & Chr(13), mau_me:=5
     ' Thaycáidâunhé MÂU_TÌM:="(Fatima )" & Chr(13), MÂU_THAY:="\1 \2phuong an 3" & Chr(13), mau_me:=5
    '  Thaycáidâunhé MÂU_TÌM:="( Fatima)([ ]{1,2})" & Chr(13), MÂU_THAY:=" \1 \2 phuong an 4" & Chr(13), mau_me:=5
     '  Thaycáidâunhé MÂU_TÌM:="(Fatima)([ ]{1,2})" & Chr(13), MÂU_THAY:="\1 \2 phuong an 5" & Chr(13), mau_me:=5
     ' Thaycáidâunhé MÂU_TÌM:="([ ]{1,2})(Fatima)([ ]{1,2})" & Chr(13), MÂU_THAY:="\1 \2 \3phuong an 6" & Chr(13), mau_me:=5
      '   Thaycáidâunhé MÂU_TÌM:="(lic)([ ]{1,2})" & Chr(13), MÂU_THAY:="\1 yyyy" & Chr(13), mau_me:=5
      
       'Thaycáidâunhé MÂU_TÌM:=Chr(13) & "([ ]{1,2})(P)", MÂU_THAY:=Chr(13) & "\1 C", mau_me:=5
               
        ' Tro vê vi trí Ðánh dâu và xóa bookmark

                        'Application.ScreenUpdating = True

On Error Resume Next
                        
                        Selection.GoTo what:=wdGoToBookmark, Name:="xxxx"
                        
                        ActiveDocument.Bookmarks("xxxx").Delete

         
End Sub
 
Đầu trang
moitinhdau
Thành viên chính thức
Thành viên chính thức
Bài viết: 15
Ngày tham gia: Thứ 7 28/05/2011 11:59 am
Has thanked: 1 time
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by moitinhdau » Thứ 4 11/03/2015 6:06 pm

Nhờ các bác giúp vấn đề này với
viewtopic.php?f=15&t=30335
Đầu trang
moitinhdau
Thành viên chính thức
Thành viên chính thức
Bài viết: 15
Ngày tham gia: Thứ 7 28/05/2011 11:59 am
Has thanked: 1 time
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by moitinhdau » Thứ 6 13/03/2015 9:54 pm

Không lẽ bó tay sao các bác.
Đầu trang
naruto3590
Bài viết: 2
Ngày tham gia: Thứ 3 17/03/2015 10:03 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by naruto3590 » Thứ 3 17/03/2015 10:11 pm

Chào mọi người! :x
Sửa lần cuối bởi 1 vào ngày naruto3590 với 0 lần sửa trong tổng số.
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 2 30/03/2015 9:09 am

naruto3590 đã viết:
e chạy nhưng nó chỉ chạy được phần số đầu tiên từ kí tự thứ 2 trở đi không chạy ra đc,

Sub newmacro()
Dim ZZZ As Long
Selection.GoTo , , 1
For ZZZ = 1 To 999
With Selection.Find
.Text = "n" & ZZZ & ""
.Replacement.Text = "@@@_(n" & ZZZ & ").___(n" & ZZZ & ")"
.Execute Replace:=wdReplaceAll
.MatchCase = True
.MatchWholeWord = False
.MatchWildcards = False
.MatchSoundsLike = False
.MatchAllWordForms = False
End With
Next
End Sub
Với lệnh .Execute Replace:=wdReplaceAll thì word sẽ tìm thay hết, do đó bạn viết:
MÃ: CHỌN TẤT CẢ

For ZZZ = 1 To 999
'. . .
Next
sẽ làm nặng máy vì vòng lặp sẽ chạy 1000 lần!

Để tìm và thay tiếp, bạn cần thêm lệnh:
MÃ: CHỌN TẤT CẢ

.Wrap = wdFindContinue
MÃ: CHỌN TẤT CẢ

Sub newmacro()
    With Selection.Find
        .Text = "n" & ZZZ & ""
        .Replacement.Text = "@@@_(n" & ZZZ & ").___(n" & ZZZ & ")"
        .Wrap = wdFindContinue
        .Execute Replace:=wdReplaceAll
        .MatchCase = True
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
End Sub
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
mrgrey
Bài viết: 1
Ngày tham gia: Thứ 3 12/05/2015 2:54 pm
Chuyển unicode dựng sẵn sang unicode tổ hợp VBA
Gửi bài by mrgrey » Thứ 3 12/05/2015 3:30 pm

Làm ơn giúp tôi chuyển unicode dựng sẵn sang unicode tổ hợp
Chi tiết là tôi thêm các text box trong excel gõ unicode dựng sẵn nó hiển thì bình thường nhưng khi in thì nó lỗi font, còn sử dụng unicode tổ hợp thì không sao.
Xin chân thành cảm ơn
Đầu trang
pretty_girl2703
Bài viết: 1
Ngày tham gia: Thứ 2 29/06/2015 2:26 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by pretty_girl2703 » Thứ 2 29/06/2015 2:52 pm

Xin chào mọi người ạ. Em là thành viên mới học về VBA xin được giúp đỡ.Hiện tại, em đang muốn viết code VBA excel với nội dung như sau:

Em muốn lấy dữ liệu từ file "Incoming Inspection Result Report" sao chép sang file "Report" theo như layout của file "Report". Em cũng đã viết thử nhưng không chạy được.
Trong file "Report" có cột "Kiểm tra kích thước" (A,B,C,D,E,F,G,H,I,J,K,L,M,N) thì được nhập số liệu như vùng bôi màu xanh da trời. Cứ mỗi lần QC nhập kích thước được đo theo chuẩn, và số lần đo tùy thuộc vào số lượng sản xuất từ nhà cung cấp (Ví dụ ở đây, sản xuất ra 200 con hàng,mức độ kiểm tra là giảm nhẹ (GN) thì chỉ cần kiểm tra đo kích thước 3 lần). Em mong muốn,có 1 nút bấm mà sau khi nhập hết 3 lần đo, dữ liệu sẽ tự động lưu dữ liệu từ file "Incoming Inspection Result Report" sang "Report", sau đó dữ liệu cũ sẽ được xóa và QC sẽ nhập mã hàng khác với số lượng khác,và sau khi xong thì sẽ tiếp tục lưu dữ liệu mới vừa nhập vào file "Report" ở những dòng tiếp theo.
Dưới đây là 2 file em đề cập đến ạ.
Rất mong các anh chị giúp đỡ em.Em ngồi mò viết cả mấy bữa nay mà không ra.

Em xin chân thành cám ơn ạ.
TẬP TIN ĐÍNH KÈM
Thac Mac VBA trong Excel.7z
2 file được đề cập ở trên
(46.59 KiB) Đã tải về 270 lần
Đầu trang
huyndh
Bài viết: 2
Ngày tham gia: Thứ 6 14/08/2015 10:21 am
Xin giúp đỡ code đọc số thành chữ, đọc điểm bài thi ấy các bác
Gửi bài by huyndh » Thứ 6 14/08/2015 10:40 am

Tình hình là mình cop đc code đọc số thành chữ trong excel, nhưng nó dùng trong kế toán.
Mình chỉ cần đọc từng số VD 7,7 đọc la bảy phẩy 7
Mình không rành về VB nên rất mong sự giúp đỡ của các bạn
Nó đây @@


MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Function DocSoVni(conso) As String
s09 = Array("", " moät", " hai", " ba", " boán", " naêm", " saùu", " baûy", " taùm", " chín")
lop3 = Array("", " trieäu", " nghìn", " tyû")
If Trim(conso) = "" Then
DocSoVni = ""
ElseIf IsNumeric(conso) = True Then
If conso < 0 Then dau = "aâm " Else dau = ""
conso = Application.WorksheetFunction.Round(Abs(conso), 0)
conso = " " & conso
conso = Replace(conso, ",", "", 1)
vt = InStr(1, conso, "E")
If vt > 0 Then
sonhan = Val(Mid(conso, vt + 1))
conso = Trim(Mid(conso, 2, vt - 2))
conso = conso & String(sonhan - Len(conso) + 1, "0")
End If
conso = Trim(conso)
sochuso = Len(conso) Mod 9
If sochuso > 0 Then conso = String(9 - (sochuso Mod 12), "0") & conso
docso = ""
i = 1
lop = 1
Do
n1 = Mid(conso, i, 1)
n2 = Mid(conso, i + 1, 1)
n3 = Mid(conso, i + 2, 1)
baso = Mid(conso, i, 3)
i = i + 3
If n1 & n2 & n3 = "000" Then
If docso <> "" And lop = 3 And Len(conso) - i > 2 Then s123 = " tyû" Else s123 = ""
Else
If n1 = 0 Then
If docso = "" Then s1 = "" Else s1 = " khoâng traêm"
Else
s1 = s09(n1) & " traêm"
End If
If n2 = 0 Then
If s1 = "" Or n3 = 0 Then
s2 = ""
Else
s2 = " linh"
End If
Else
If n2 = 1 Then s2 = " möôøi" Else s2 = s09(n2) & " möôi"
End If
If n3 = 1 Then
If n2 = 1 Or n2 = 0 Then s3 = " moät" Else s3 = " moát"
ElseIf n3 = 5 And n2 <> 0 Then
s3 = " laêm"
Else
s3 = s09(n3)
End If
If i > Len(conso) Then
s123 = s1 & s2 & s3
Else
s123 = s1 & s2 & s3 & lop3(lop)
End If
End If
lop = lop + 1
If lop > 3 Then lop = 1
docso = docso & s123
If i > Len(conso) Then Exit Do
Loop
If docso = "" Then DocSoVni = "khoâng" Else DocSoVni = dau & Trim(docso)
Else
DocSoVni = conso
End If
End Function
Function DocSoUni(conso) As String
s09 = Array("", " m" & ChrW(7897) & "t", " hai", " ba", " b" & ChrW(7889) & "n", " n" & ChrW(259) & "m", " s" & ChrW(225) & "u", " b" & ChrW(7843) & "y", " t" & ChrW(225) & "m", " ch" & ChrW(237) & "n")
lop3 = Array("", " tri" & ChrW(7879) & "u", " ngh" & ChrW(236) & "n", " t" & ChrW(7927))
'Stop
If Trim(conso) = "" Then
DocSoUni = ""
ElseIf IsNumeric(conso) = True Then
If conso < 0 Then dau = ChrW(226) & "m " Else dau = ""
conso = Application.WorksheetFunction.Round(Abs(conso), 0)
conso = " " & conso
conso = Replace(conso, ",", "", 1)
vt = InStr(1, conso, "E")
If vt > 0 Then
sonhan = Val(Mid(conso, vt + 1))
conso = Trim(Mid(conso, 2, vt - 2))
conso = conso & String(sonhan - Len(conso) + 1, "0")
End If
conso = Trim(conso)
sochuso = Len(conso) Mod 9
If sochuso > 0 Then conso = String(9 - (sochuso Mod 12), "0") & conso
docso = ""
i = 1
lop = 1
Do
n1 = Mid(conso, i, 1)
n2 = Mid(conso, i + 1, 1)
n3 = Mid(conso, i + 2, 1)
baso = Mid(conso, i, 3)
i = i + 3
If n1 & n2 & n3 = "000" Then
If docso <> "" And lop = 3 And Len(conso) - i > 2 Then s123 = " t" & ChrW(7927) Else s123 = ""
Else
If n1 = 0 Then
If docso = "" Then s1 = "" Else s1 = " kh" & ChrW(244) & "ng tr" & ChrW(259) & "m"
Else
s1 = s09(n1) & " tr" & ChrW(259) & "m"
End If
If n2 = 0 Then
If s1 = "" Or n3 = 0 Then
s2 = ""
Else
s2 = " linh"
End If
Else
If n2 = 1 Then s2 = " m" & ChrW(432) & ChrW(7901) & "i" Else s2 = s09(n2) & " m" & ChrW(432) & ChrW(417) & "i"
End If
If n3 = 1 Then
If n2 = 1 Or n2 = 0 Then s3 = " m" & ChrW(7897) & "t" Else s3 = " m" & ChrW(7889) & "t"
ElseIf n3 = 5 And n2 <> 0 Then
s3 = " l" & ChrW(259) & "m"
Else
s3 = s09(n3)
End If
If i > Len(conso) Then
s123 = s1 & s2 & s3
Else
s123 = s1 & s2 & s3 & lop3(lop)
End If
End If
lop = lop + 1
If lop > 3 Then lop = 1
docso = docso & s123
If i > Len(conso) Then Exit Do
Loop
If docso = "" Then DocSoUni = "kh" & ChrW(244) & "ng" Else DocSoUni = dau & Trim(docso)
Else
DocSoUni = conso
End If
End Function
GeSHi © Codebox Plus Extension
Đầu trang
naruto3590
Bài viết: 2
Ngày tham gia: Thứ 3 17/03/2015 10:03 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by naruto3590 » Thứ 4 16/09/2015 8:31 pm

nhờ bro truongphu giúp đỡ với
chả là thế này em muốn replace chữ dạng ABCDE nhưng ko fai là smallcaps!
kiểu chữ đầu font 13 các chữ sau font 7 hoăc 8 chả hạn.
replace thành dạng <h>ABCDE</h>
có cách nào tìm và replace các chữ dạng này ko.
mong bro giúp đỡ
Đầu trang
tnhatanh68
Bài viết: 1
Ngày tham gia: Chủ nhật 17/01/2016 10:48 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by tnhatanh68 » Chủ nhật 17/01/2016 10:54 am

Chào mọi người,

Mình có vấn đề xin mọi người giúp đỡ như sau. Mình có 1 đoạn code với mục đích save file word theo tên mong muốn từ 1 dòng trong file word bất kì

ví dụ file word có nội dung như sau



FLIGHT RELEASE
FLT NO. FROM / TO DATE AIRCRAFT
PIC799 HAN SGN 17JAN16 VNA555

DISPATCHER ANH - DESK EXTENSION +84 8 35474520
COMMENTS
EFB VERSION: 160114V1
A a a a a a a a a a
SIGNED_______________________
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

CAPTAIN THOMPSON
FIRST OFFICER HUNG
JUMP SEAT

FILED ATC PLAN
----------------
(FPL-PIC799-IS
-A320/M-SDFGHIRWY/LB1
-VVNB1455
-N0457F360 VITRA2A VITRA DCT NAH W1 HAMIN W10 PLK W1 AC ANLOC1B
-VVTS0141 VVPQ VVDN
-PBN/A1D1O1 DOF/160117 REG/VNA555
EET/VVTS0037
SEL/EKDM CODE/8880A7 OPR/JETSTAR PACIFIC PER/C RMK/TCAS EQUIPPED
E/0255 P/TBN R/VE J/L D/0 A/GRAY C/THOMPSON)

Và mình muốn copy nội dung dòng được tô đậm để làm tên lưu cho file (PIC799 HAN SGN 17JAN16 VNA555)

Nhưng không biết sao khi làm tay để record vào thì bình thường, nhưng khi bâm run macro để chạy thì nó báo lỗi 5487 file permission error.

Code như sau
MÃ: CHỌN TẤT CẢ

Sub test()
'
' test Macro
'
'
   Dim k As String, t As String


    Selection.MoveUp Unit:=wdLine, Count:=500
    Selection.MoveDown Unit:=wdLine, Count:=4
    Selection.HomeKey Unit:=wdLine
    Selection.EndKey Unit:=wdLine, Extend:=wdExtend
    Selection.Copy
    k = Selection.Text
    
    t = "D:\OCC\" & k & ".docx"
    
    

    ChangeFileOpenDirectory "D:\OCC\"
    ActiveDocument.SaveAs2 FileName:=t, FileFormat:= _
        wdFormatXMLDocument, LockComments:=False, Password:="", AddToRecentFiles _
        :=True, WritePassword:="", ReadOnlyRecommended:=False, EmbedTrueTypeFonts _
        :=False, SaveNativePictureFormat:=False, SaveFormsData:=False, _
        SaveAsAOCELetter:=False, CompatibilityMode:=14
   
End Sub
Xin nhờ mọi người giúp đỡ [-O<
Đầu trang
vinnycf
Bài viết: 1
Ngày tham gia: Thứ 5 18/08/2016 2:31 pm
TỰ ĐỘNG NHẢY CHỮ KHI ĐÁNH VÀO Ô ĐẦU TIÊN
Gửi bài by vinnycf » Thứ 5 18/08/2016 2:37 pm

Hi cả nhà, em có vấn đề này nhờ cả nhà giúp với.
Hiện tại em đang soạn thảo 1 văn bản và sẽ có vài trường thông tin trùng lặp, em muốn khi đánh 1 trường lúc đầu thì các trường phía tự động nhảy lại đúng nội dung như em đã đánh.
Bên excel thì mình có dùng "=" chọn ô, còn bên word thì em không biết có cách nào không.

Tên: A
Nghê nghiệp: xxxx
Tên:

Em đánh tên: A thì các trường sau khi có trùng tiêu đề "Tên" cũng nhay thành A ạ
Đầu trang
NTK.vb6
Bài viết: 9
Ngày tham gia: Thứ 7 17/09/2016 10:04 am
Been thanked: 1 time
SaveAs file MSWord không được như ý muốn.
Gửi bài by NTK.vb6 » Thứ 7 17/09/2016 11:22 am

Khi mình SaveAs file trong vòng lặp For thì đều trả về kết quả là "A1". trong khi đáng lẽ phải là "A1","A2","A3","A4".
dưới đây là code của mình. mong mọi người giúp đỡ!
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
    Dim WordApp As New Word.Application
    Dim DocApp As Word.Document
    Dim SelectApp As Object
    Set DocApp = WordApp.Documents.Open("D\Lap trinh VB\On tap\data\mauvd1.doc")
    Set SelectApp = WordApp.Selection
    For i = 1 To 4
        SelectApp.Find.ClearFormatting
        SelectApp.Find.Replacement.ClearFormatting
        With SelectApp.Find
            .Text = "1DiaChiThuaDat"
            .Replacement.Text = "A" & i
            .Forward = True
            .Wrap = wdFindContinue
            .Format = False
            .MatchCase = False
            .MatchWholeWord = False
            .MatchWildcards = False
            .MatchSoundsLike = False
            .MatchAllWordForms = False
        End With
        SelectApp.Find.Execute Replace=wdReplaceAll
        DocApp.SaveAs2 "D\Lap trinh VB\On tap\ket qua" & "kq_" & i & ".doc"
    Next
    DocApp.Close
    MsgBox "xong"
GeSHi © Codebox Plus Extension
Đầu trang
Tracdac
Bài viết: 1
Ngày tham gia: Thứ 6 07/10/2016 8:27 am
Tiếp xúc: Liên hệ Tracdac
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Tracdac » Thứ 6 07/10/2016 8:31 am

Em muốn lập trình lisp chạy trên Autocad nhưng trình độ gà mờ quá
WWW.DODACBANDO.COM
Đầu trang
thuonghieuso
Bài viết: 4
Ngày tham gia: Thứ 7 12/11/2016 3:19 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by thuonghieuso » Thứ 5 17/11/2016 5:03 pm

Chào các bạn!
Cho mình hỏi một vấn đề thế này.
Mình có các câu hỏi như sau:
Câu 1: Nội dung
Câu 2: Nôi dung câu hỏi
Câu 3: Nội dung
Câu 4: Nôi dung câu hỏi
Câu 5: Nội dung
Câu 6: Nôi dung câu hỏi

Bây giờ mình muốn sử dụng Macro để thay đổi các chữ "Câu 1, Câu 2, Câu 3 ..." thành một chữ khác. Ví dụ đổi thành "@ Nội dung" thì phải làm như thế nào?
Nhờ các bạn giúp đỡ.
Đầu trang
Hình đại diện của thành viêntrungtamcnc
Bài viết: 2
Ngày tham gia: Thứ 3 15/07/2014 4:39 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by trungtamcnc » Thứ 2 05/12/2016 11:50 pm

Gửi bạn: thuonghieuso
Bạn làm như sau: Ấn Ctrl + H (tìm kiếm và thay thế)
Ô tìm kiếm: Nhập Câu ^?:
Ô thay thế: @Nội dung

Oke là xong.
Đầu trang
thuonghieuso
Bài viết: 4
Ngày tham gia: Thứ 7 12/11/2016 3:19 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by thuonghieuso » Thứ 6 23/12/2016 8:50 pm

Gửi bạn: thuonghieuso
Bạn làm như sau: Ấn Ctrl + H (tìm kiếm và thay thế)
Ô tìm kiếm: Nhập Câu ^?:
Ô thay thế: @Nội dung

Oke là xong.
Nhưng làm như vậy thì nó chỉ replace được tới số <10. Từ 10 trở lên là nó không được.
Thanks bạn nhé !
Đầu trang
anhducnavy688
Bài viết: 1
Ngày tham gia: Thứ 3 27/12/2016 11:07 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by anhducnavy688 » Thứ 4 28/12/2016 3:20 pm

Chào các ae
Hiện tại em mới về làm giảng viên, muốn làm một đề tài nho nhỏ, em cũng mới nghiên cứu về VBA, và đã đọc rất nhiều bài của a trên các diễn đàn, tuy nhiên do thời gian có hạn, và nhiều nội dung em không thể tìm hiểu hết. Em muốn a trợ giúp e một vẫn đề nho nhỏ, em tìm bấy lâu nay chưa thấy.
Ý tưởng là em làm 1 cái tự đồng trộn đề thi, theo cấu trúc sắp xếp sẵn, tuy nhiên có 1 nội dung vướng.
Trong file Ngân hàng câu hỏi, giả sử em như sau:
[CH]
Câu 1: Hãy trình bày các giai đoạn lượn vòng?
[CH]
Câu 2: Đ/c trực canh phát hiện có người rơi xuống nước mạn trái,
Trên cương vị được giao, đ/c phải làm gì?
[CH]
Câu 3
.......
Giả sử em muốn chọn nội dung câu 2 thì ntn ạ, và làm sao để lấy nội dung câu đó, chèn vào sau 1 đoạn tiêu đề đề thi đặt ra sẵn


Ví dụ tiêu đề đề thi: ĐỀ THI HỌC KỲ II
Môn: Điều động tàu và QTTV
Ae trợ giúp em lấy nội dung câu 2, chèn vào sau đoạn tiêu đề đó được k ạ, em cám ơn a nhiều. Mong nhận được hồi âm sớm nhất của a ạ
Đầu trang
207 bài viết    …   9   
Quay về
Trang chủDiễn đànThời gian được tính theo giờ UTC+07:00 UTC+7Xoá cookie của websiteLiên hệ chúng tôi
Đã tích hợp phpBB® Forum Software © phpBB Limited

Vietnamese language pack for phpBB 3.2.x download and support.

PRIVACY_LINK | TERMS_LINK


Page 10



Câu lạc bộ Visual Basic
.:: Nơi trao đổi về ngôn ngữ Visual Basic ::.

Bỏ qua nội dung

Nhập từ khóa tìm kiếm…
Đường dẫn nhanhTrợ giúpĐăng nhập
Trang chủDiễn đànTHẮC MẮC - TRAO ĐỔI - THẢO LUẬNVisual Basic for Application (VBA)
Trao đổi về Word VBA Mời vào đây!
Điều hành viên: tungblt

Nội quy chuyên mục

Tìm kiếm trong chủ đề này…
207 bài viết    …    10  
vinhthichip
Bài viết: 1
Ngày tham gia: Thứ 4 23/11/2016 4:33 pm
Chia nhỏ file .pdf
Gửi bài by vinhthichip » Thứ 4 11/01/2017 1:20 pm

Tôi có 1 thư .pdf gồm nhiều khách hàng. Giờ muốn chia mỗi trang là 1 khách hàng, tên file là mã khách hàng. Sư phụ nào giúp mình với, cảm ơn nhiều.
nnthi.gla@gmail.com
ĐT: 0977990900
Đầu trang
dzung
Bài viết: 1
Ngày tham gia: Thứ 2 19/11/2012 7:40 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by dzung » Thứ 6 17/03/2017 7:05 am

anh TruongPhu ơi cho xin lại code , trong bài cũ viewtopic.php?t=21600#p119000
cái Userform như hình không thấy . Thanks
Đầu trang
chinh2308
Bài viết: 1
Ngày tham gia: Thứ 7 01/04/2017 3:40 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by chinh2308 » Thứ 7 01/04/2017 3:53 pm

Chào a phú.
Em có một vấn đề xin được a giúp đỡ.
Đang có 1 file câu hỏi như sau:
Phần hỏi:
Câu 1. abcxyz
Câu 2. abkh
Câu 3. dfdfsd

Phần trả lời:
Câu 1. kjlk
Câu 2. jlkj
Câu 3. ịojo

Em muốn ghép các câu trả lời vào từng câu hỏi như là:
Câu 1. abcxyz
trả lời: kjlk
Câu 2. abkh
trả lời: jkkj
...
Mong được a giúp đỡ. Cảm ơn anh nhiều
file mẫu đính kèm.
TẬP TIN ĐÍNH KÈM
ghep.rar
(34.26 KiB) Đã tải về 193 lần
Đầu trang
thuonghieuso
Bài viết: 4
Ngày tham gia: Thứ 7 12/11/2016 3:19 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by thuonghieuso » Thứ 2 22/05/2017 4:47 pm

Chào Bác Phú.
Em cần giúp đỡ.
Em có 1 đoạn như thế này.
Câu hỏi: Bầu trời kia thật xanh biếc. Nhìn lên đó có biết bao là ........?
a. Mây
b. Trăng
c. Sao
d. Mặt trời.
Em muốn Tìm và thay thế ("C.") . Nhưng lúc tìm và thay thế thì nó thay thế cả 2 chỗ . Chữ biếc. và C. Sao. Làm sao để phân biệt được 2 chỗ trên. E chỉ muốn thay thế bên dưới.
Mong bác giúp đỡ.
Đầu trang
nhu2017
Bài viết: 1
Ngày tham gia: Thứ 3 18/07/2017 12:40 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by nhu2017 » Thứ 5 20/07/2017 9:57 pm

bác truongphu có tài liệu về VBA word bằng tiếng việt không? cho tiện anh em nghiên cứu
Đầu trang
awakealove
Bài viết: 6
Ngày tham gia: Thứ 3 10/01/2012 7:44 pm
Has thanked: 1 time
MailMerge Trong Word VBA code Xin Giúp đỡ
Gửi bài by awakealove » Thứ 5 19/10/2017 8:49 pm

Em có:
- File word tên MMerge.doc
- File excel tên Source.xls
Yêu cầu:
1. Khi mở file MMerge.doc lên thì tự động set DataSource cho File word từ file excel Source.xls (Sheet1) để dùng trộn thư
2. Trên file word MMerge.doc có 1 nút lệnh tên CmdExp, khi click nút này thì sẽ tự động lưu ra file word mới theo Record hiện tại
(Merge to New Document). Chỉ cần trích mẫu tin hiện tại không phải trích toàn bộ.

Xin mọi người giúp đỡ!
Đầu trang
vongcohay
Bài viết: 4
Ngày tham gia: Thứ 3 14/02/2017 7:25 am
Has thanked: 3 times
Been thanked: 1 time
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by vongcohay » Thứ 3 13/03/2018 9:59 am

anh em cho mình hỏi, trong word muốn tìm chữ màu xanh gạch chân (single) thay thế bằng màu đỏ thì làm sao? cám ơn
Đầu trang
loannguyen14141993
Bài viết: 2
Ngày tham gia: Thứ 2 19/03/2018 10:14 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by loannguyen14141993 » Thứ 2 19/03/2018 10:25 am

giúp e bài này với ạ

stt m n tổng từ m đến n dùng hàm Vba để tính tổng m đến n biết m<n.(sumMToN)
1 1 10 biết rằng m,n as integer, kiểu trả về sumMToN cũng là integer
2 2 15
3 3 18
4 5 21
5 6 25
6 7 30
7 8 37
8 9 40
9 10 45
Đầu trang
loannguyen14141993
Bài viết: 2
Ngày tham gia: Thứ 2 19/03/2018 10:14 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by loannguyen14141993 » Thứ 2 19/03/2018 10:34 am

và bài này nữa ạ
TT NGÀY TÊN TRƯỜNG DÂN TỘC ĐIỂM ƯU TIÊN
01 01/01/2003 NGUYỄN THỊ NHUNG ĐH Nông lâm Kinh
02 03/01/2003 NGUYỄN TẤN HÙNG ĐH Bách Khoa Nùng
03 05/01/2003 VÕ THỊ LÝ ĐH sư phạm Kinh
04 18/01/2003 HuỲNH VĂN MẪN ĐH Nông lâm Ê Đê
05 25/01/2003 LÂM KHỞI ĐH Bách Khoa H' Mông
06 04/02/2003 NGUYỄN TRẦN NA ĐH Nông lâm Gia Rai
07 10/02/2003 PHẠM VĂN HÙNG ĐH Bách Khoa Kinh
08 11/02/2003 TRẦN THIỆN TÂN ĐH sư phạm Kinh
09 17/02/2003 NGÔ THỊ BƯỞI ĐH Nông lâm Tày
10 26/02/2003 VÕ THỊ MAI LOAN ĐH Bách Khoa Kinh
11 01/03/2003 TRẦN LÊ QuỐC ĐH sư phạm Kinh
12 10/03/2003 TRẦN VĂN DŨNG ĐH sư phạm Tày

Yêu cầu: Tính điểm ưu tiên. Nếu không phải dân tộc kinh mà thi vào trường Đại học Nông Lâm hoặc Đại học Bách Khoa thì điểm ưu tiên là 1.5 còn lại điểm ưu tiên bằng 0. Trong đó điểm ưu tiên as double, dân tộc và trường đại học as string
Đầu trang
dung2873
Bài viết: 1
Ngày tham gia: Thứ 4 19/02/2014 9:13 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by dung2873 » Thứ 7 25/08/2018 3:09 pm

Chào mọi người mình có vài cái thắc mắc chưa thông mong mọi người chỉ giáo
Mình có gõ lại mấy đoạn code trong word, với mục đích là tìm câu và tách câu hỏi trắc nghiệm theo một điều kiện nhưng khi cho chạy bị lỗi không biết phải khắc phục như thế nào? Có kèm theo tập tin để tách
MÃ: [CHỌN TẤT CẢ] [MỞ RỘNG/THU HẸP]
Sub Tach_cau_Mucdo()
ActiveDocument.Range.ListFormat.ConvertNumbersToText
Dim NameGoc, PathGoc, OldExt, OldName, NameTach, NameTam As String
NameGoc = ActiveDocument.Name
PathGoc = ActiveDocument.Path
OldExt = Split(NameGoc, ".")(UBound(Split(NameGoc, ".")))
OldName = Left(NameGoc, Len(NameGoc) - Len(OldExt))
Application.Visible = False
Dim socau As Integer
    socau = 0
    Selection.HomeKey unit=wdStory
    Selection.Find.ClearFormatting
        With Selection.Find
        .Text = "Câu [0-9]{1,3}[.][^9^32]"
        .Forward = True
        .Wrap = wdFindContinue
        .MatchCase = True
        .MatchWildcards = True
    End With
    Do While Selection.Find.Execute = True
        socau = socau + 1
    Loop
Selection.EndKey unit=wdStory
    Selection.ParagraphFormat.TabStops.ClearAll
    Selection.ParagraphFormat.FirstLineIndent = CentimetersToPoints(-0.5)
    Selection.TypeParagraph
    Selection.Font.Name = "Time New Roman"
    Selection.Font.Size = 12
    Selection.Font.Bold = True
    Selection.Font.Color = wdColorDarkBlue
    Selection.TypeText Text="Câu " & socau + 1 & ". "
For i = 1 To socau
    Cau = "Câu " & i
    Cauke = "Câu " & i + 1
Selection.HomeKey unit=wdStory
    NameTach = "C" & 1 & "_" & NameGoc
Dim GocDoc, TamDoc As Document
    Set GocDoc = ActiveDocument
    Selection.Find.ClearFormatting
    With Selection.Find
        .Text = Câu & "([.]*)" & Cauke
        .MatchWildcards = True
    If Selection.Find.Execute = True Then
        Set TamDoc = Documents.Add(DocumentType=wdNewBlankDocument)
    Else
        Exit Sub
    End If
    GocDoc.Activate
        Selection.Copy
    TamDoc.Activate
        Selection.PasteAndFormat (wdFormatOriginalFormatting)
    End With
Selection.HomeKey unit=wdStory
    With Selection.Find
        .Font.Color = wdColorPink
        .Text = "(\[*\])"
        .MatchCase = False
        .MatchWildcards = True
        .Execute
    End With
    Selection.Copy
    NameTach = Selection.Text & NameTach
If Dir(PathName & "" & OldName, vbDirectory) = "" Then
        MkDir (PathGoc & "" & OldName)
End If
    NameTam = PathGoc & "" & OldName & "" & NameTach
    TamDoc.SaveAs NameTam
    ActiveWindow.Close (no)
Next
GocDoc.Activate
Application.Visible = True
MsgBox "Xong"
GocDoc.Close (no)
End Sub
Sub SapXepMucDo()
ActiveDocument.Range.ListFormat.ConvertNumbersToText
Dim NameGoc, PathGoc, OldExt, OldName, NameTach, NameTam As String
NameGoc = ActiveDocument.Name
PathGoc = ActiveDocument.Path
OldExt = Split(NameGoc, ".")(UBound(Split(NameGoc, ".")))
OldExt = "." & OldExt
OldName = Left(NameGoc, Len(NameGoc) - Len(OldExt))
OldName = "[" & OldName & "]"
Application.Visible = False
Dim socau As Integer
    socau = 0
    Selection.HomeKey unit=wdStory
    Selection.Find.ClearFormatting
        With Selection.Find
        .Text = "Câu [0-9]{1,3}[.][^9^32]"
        .Forward = True
        .Wrap = wdFindContinue
        .MatchCase = False
        .MatchWildcards = True
    End With
    Do While Selection.Find.Execute = True
        socau = socau + 1
    Loop
Selection.EndKey unit=wdStory
    Selection.ParagraphFormat.TabStops.ClearAll
    Selection.ParagraphFormat.FirstLineIndent = CentimetersToPoints(-0.5)
    Selection.TypeParagraph
    Selection.Font.Name = "Time New Roman"
    Selection.Font.Size = 12
    Selection.Font.Bold = True
    Selection.Font.Color = wdColorDarkBlue
    Selection.TypeText Text="Câu " & socau + 1 & ". "
For i = 1 To socau
    Cau = "Câu " & i
    Cauke = "Câu " & i + 1
Selection.HomeKey unit=wdStory
    NameTach = "C" & i & OldExt
Dim GocDoc, TamDoc As Document
    Set GocDoc = ActiveDocument
    Selection.Find.ClearFormatting
    With Selection.Find
        .Text = Câu & "([.]*)" & Cauke
        .MatchWildcards = True
    If Selection.Find.Execute = True Then
        Set TamDoc = Document.Add(DocumentType=wdNewBlankDocument)
    Else
        Exit Sub
    End If
    GocDoc.Activate
        Selection.Copy
    TamDoc.Activate
        Selection.PasteAndFormat (wdFormatOriginalFormatting)
    End With
Selection.HomeKey unit=wdStory
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = Cau & "([.]*)" & Cauke
        .Replacement.Text = Cau & "\1"
        .MatchWildcards = True
        .Execute Replace=wdReplaceOne
    End With
Selection.HomeKey unit=wdStory
    With Selection.Find
        .Font.ColorIndex = wdColorPink
        .Text = "(\1*\1)"
        .MatchCase = False
        .MatchWildcards = True
        .Execute
    End With
    Selection.Copy
    MaID = Selection.Text
    mucdo = Right(MaID, 2)
    NameTach = "[" & mucdo & MaID & NameTach
If Dir(PathGoc & "" & OldName, vbDirectory) = "" Then
        MkDir (PathGoc & "" & OldName)
End If
    NameTam = PathGoc & "" & OldName & "" & NameTach
    TamDoc.SaveAs NameTam
    ActiveWindow.Close (no)
Next
GocDoc.Activate
Dim FSO As Object, Content As String
Dim folder As Object, subfolder As Object
Dim GhepDoc As Document
Set FSO = CreateObject("Scripting.FileSystemObject")
folderPath = PathGoc & "" & OldName
Set folder = FSO.GetFolder(folderPath)
DocName = PathGoc & "\[MucDo]" & NameGoc
If Dir(DocName) = "" Then
        Set GhepDoc = Documents.Add(DocumentType=wdNewBlankDocument)
        ActiveDocument.SaveAs DocName
   End If
For Each Wd In folder.Files
    Selection.InsertFile FileName=Wd.Path
Next
Selection.HomeKey unit=wdStory
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Câu [0-9]{1,3}[.][^9^32]'"
        .Replacement.Text = "#"
        .Forward = True
        .MatchCase = True
        .MatchWildcards = True
        .Wrap = wdFindContinue
        .Execute Replace=wdRelpaceAll
    End With
Dim sott As Integer
    sott = 0
    Selection.HomeKey unit=wdStory
    Selection.Find.ClearFormatting
        With Selection.Find
        .Text = "#"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWildcards = False
    End With
    Do While Selection.Find.Execute = True
        sott = sott + 1
    Selection.ParagraphFormat.TabStops.ClearAll
    Selection.ParagraphFormat.FirstLineIndent = CentimetersToPoints(-0.5)
    Loop
    Selection.HomeKey unit=wdStory
For k = 1 To sott
    With Selection.Find
        .Text = "#"
        .Replacement.Text = "Câu " & k & ". "
        .Replacement.Font.Color = wdColorDarkBlue
        .Replacement.Font.Bold = True
        .Forward = True
        .MatchCase = True
        .Execute Replace=wdRelpaceAll
    End With
 Next
    With Selection.Find
        .Text = "^32^32"
        .Replacement.Text = " "
        .Forward = False
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWildcards = False
        Do While .Execute
            .Execute Replace=wdReplaceAll
        Loop
    End With
ActiveDocument.Save
ActiveWindow.Close
 
Kill (folderPath & "\*.doc")
RmDir (folderPath)
 
Application.Visible = True
MsgBox "Xong"
GocDoc.Close (no)
End Sub
Sub SapXepID()
ActiveDocument.Range.ListFormat.ConvertNumbersToText
Dim NameGoc, PathGoc, OldExt, OldName, NameTach, NameTam As String
NameGoc = ActiveDocument.Name
PathGoc = ActiveDocument.Path
OldExt = Split(NameGoc, ".")(UBound(Split(NameGoc, ".")))
OldExt = "." & OldExt
OldName = Left(NameGoc, Len(NameGoc) - Len(OldExt))
OldName = "[" & OldName & "]"
Application.Visible = False
Dim socau As Integer
 socau = 0
    Selection.HomeKey unit=wdStory
    Selection.Find.ClearFormatting
        With Selection.Find
        .Text = "Câu [0-9]{1,3}[.][^9^32]"
        .Forward = True
        .Wrap = wdFindContinue
        .MatchCase = False
        .MatchWildcards = True
    End With
    Do While Selection.Find.Execute = True
        socau = socau + 1
    Loop
Selection.EndKey unit=wdStory
    Selection.ParagraphFormat.TabStops.ClearAll
    Selection.ParagraphFormat.FirstLineIndent = CentimetersToPoints(-0.5)
    Selection.TypeParagraph
    Selection.Font.Name = "Time New Roman"
    Selection.Font.Size = 12
    Selection.Font.Bold = True
    Selection.Font.Color = wdColorDarkBlue
    Selection.TypeText Text="Câu " & socau + 1 & ". "
For i = 1 To socau
    Cau = "Câu " & i
    Cauke = "Câu " & i + 1
Selection.HomeKey unit=wdStory
    NameTach = "C" & i & OldExt
Dim GocDoc, TamDoc As Document
    Set GocDoc = ActiveDocument
    Selection.Find.ClearFormatting
    With Selection.Find
        .Text = Câu & "([.]*)" & Cauke
        .MatchWildcards = True
    If Selection.Find.Execute = True Then
        Set TamDoc = Document.Add(DocumentType=wdNewBlankDocument)
    Else
        Exit Sub
    End If
    GocDoc.Activate
        Selection.Copy
    TamDoc.Activate
        Selection.PasteAndFormat (wdFormatOriginalFormatting)
    End With
Selection.HomeKey unit=wdStory
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = Cau & "([.]*)" & Cauke
        .Replacement.Text = Cau & "\1"
        .MatchWildcards = True
        .Execute Replace=wdReplaceOne
    End With
Selection.HomeKey unit=wdStory
    With Selection.Find
        .Font.Color = wdColorPink
        .Text = "(\[*\])"
        .MatchCase = False
        .MatchWildcards = True
        .Execute
    End With
    Selection.Copy
    MaID = Selection.Text
    mucdo = Right(MaID, 2)
    NameTach = MaID & NameTach
If Dir(PathGoc & "" & OldName, vbDirectory) = "" Then
        MkDir (PathGoc & "" & OldName)
End If
    NameTam = PathGoc & "" & OldName & "" & NameTach
    TamDoc.SaveAs NameTam
    ActiveWindow.Close (no)
Next
GocDoc.Activate
Dim FSO As Object, Content As String
Dim folder As Object, subfolder As Object
Dim GhepDoc As Document
Set FSO = CreateObject("Scripting.FileSystemObject")
folderPath = PathGoc & "" & OldName
Set folder = FSO.GetFolder(folderPath)
DocName = PathGoc & "\[ID]" & NameGoc
If Dir(DocName) = "" Then
        Set GhepDoc = Documents.Add(DocumentType=wdNewBlankDocument)
        ActiveDocument.SaveAs DocName
   End If
For Each Wd In folder.Files
    Selection.InsertFile FileName=Wd.Path
Next
Selection.HomeKey unit=wdStory
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "^P^P"
        .Replacement.Text = "^P"
        .Forward = True
        .MatchCase = True
        .MatchWildcards = True
        .Wrap = wdFindContinue
        .Execute Replace=wdRelpaceAll
    End With
Selection.HomeKey unit=wdStory
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Câu [0-9]{1,3}[.][^9^32]"
        .Replacement.Text = "#"
        .Forward = True
        .MatchCase = True
        .MatchWildcards = True
        .Wrap = wdFindContinue
        .Execute Replace=wdReplaceAll
    End With
Dim sott As Integer
    sott = 0
    Selection.HomeKey unit=wdStory
    Selection.Find.ClearFormatting
        With Selection.Find
        .Text = "#"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWildcards = False
    End With
    Do While Selection.Find.Execute = True
        sott = sott + 1
    Selection.ParagraphFormat.TabStops.ClearAll
    Selection.ParagraphFormat.FirstLineIndent = CentimetersToPoints(-0.5)
    Loop
    Selection.HomeKey unit=wdStory
For k = 1 To sott
    With Selection.Find
        .Text = "#"
        .Replacement.Text = "Câu " & k & ". "
        .Replacement.Font.Color = wdColorDarkBlue
        .Replacement.Font.Bold = True
        .Forward = True
        .MatchCase = True
        .Execute Replace=wdRelpaceAll
    End With
 Next
    With Selection.Find
        .Text = "^32^32"
        .Replacement.Text = " "
        .Forward = False
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWildcards = False
        Do While .Execute
            .Execute Replace=wdReplaceAll
        Loop
    End With
ActiveDocument.Save
ActiveWindow.Close
 
Kill (folderPath & "\*.doc")
RmDir (folderPath)
 
Application.Visible = True
MsgBox "Xong"
GocDoc.Close (no)
    End Sub
GeSHi © Codebox Plus Extension
TẬP TIN ĐÍNH KÈM
VINHPHUC1.rar
(915.48 KiB) Đã tải về 131 lần
Đầu trang
phongthandell
Bài viết: 1
Ngày tham gia: Thứ 5 28/02/2013 4:24 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by phongthandell » Thứ 4 27/02/2019 5:55 pm

Nhờ bác chỉ dùm! Chuyển trắc nghiệm trên trang word, các câu đó nằm trong khung kẻ chuyển về dạng bình thường có đánh đáp án đúng ở mỗi câu! (Xem file đính kèm dùm)
Xin bác giúp dùm cháu!
TẬP TIN ĐÍNH KÈM
quiz-C1 ĐHCĐ-Bài 2-20190227-1747.zip
(14.01 KiB) Đã tải về 118 lần
Đầu trang
chaufcv
Bài viết: 3
Ngày tham gia: Thứ 5 16/04/2009 3:45 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by chaufcv » Thứ 2 23/09/2019 10:19 pm

Mới ngày nào mọi người cùng nhau thảo luận học hỏi lẫn nhau giờ thì chỉ còn 1 vài khách ghé thăm hoặc tìm kiếm 1 cái gì đó còn sài được. Không biết bây giờ còn những ai vẫn còn ghé .. buồn quá không biết viết gì thêm. công nghệ phát triển nhanh quá nhưng nếu ta thích thì bất cứ ngôn ngữ nào cũng có thể giải quyết được hết.
Tuy mình không phải là 1 người lập trình nhưng cũng từ đây mình có thể vận dụng nó vào tin học văn phòng để làm việc hiệu quả hơn Cám ơn caulacbovb và người nhiệt tình đầy tâm huyết nhất là bác Phú.
Đầu trang
vj3850
Bài viết: 1
Ngày tham gia: Thứ 4 06/11/2019 10:43 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by vj3850 » Thứ 5 07/11/2019 7:43 am

Mình chạy Macro bị lỗi ở section.copy giống này bác nào có kinh nghiệm giúp e tí ạ, e mới mò mẫm thôi :D
TẬP TIN ĐÍNH KÈM
0A13E4ED-35EC-4390-97B4-5B754D028BB5.jpeg
0A13E4ED-35EC-4390-97B4-5B754D028BB5.jpeg (19.06 KiB) Đã xem 6790 lần
C5C03961-216B-4081-A6CC-2F0BE6B9EC0F.jpeg
C5C03961-216B-4081-A6CC-2F0BE6B9EC0F.jpeg (31.65 KiB) Đã xem 6790 lần
3DC877F5-B711-4A86-B897-E3A0C051C647.jpeg
3DC877F5-B711-4A86-B897-E3A0C051C647.jpeg (31.65 KiB) Đã xem 6790 lần
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 7 23/11/2019 6:44 pm

Selection trên MS Word là dấu nháy.
Bạn phải bôi đen đoạn văn, tối thiểu là 1 ký tự thì Selection.Copy mới hoạt động được chứ! OK?
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
kvanthuong
Bài viết: 1
Ngày tham gia: Thứ 3 15/10/2019 8:43 am
NHỜ CAO NHÂN GIÚP ĐỠ
Gửi bài by kvanthuong » Thứ 3 31/12/2019 3:33 pm

EM LÀ GV TIỂU HỌC, HIỆN E ĐANG LÀM CHƯƠNG TRÌNH GAME ĐƯỜNG LÊN ĐỈNH OLYMPIA NHƯNG KHÔNG CHUYÊN VỀ VISUAL BASIC NÊN NHỜ CÁC CAO NHÂN SỬA GIÚP EM CÁCH TÍNH ĐIỂM TỰ ĐỘNG VÀ LIÊN KẾT PHẦN ĐIỂM GIỮA CÁC PHẦN THI.
XIn cảm ơn!
http://upfile.vn/_QjmZqBmNVLg/olympia-khoi-5-zip.html
Đầu trang
nguyencongtinh
Bài viết: 1
Ngày tham gia: Chủ nhật 19/07/2020 4:44 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by nguyencongtinh » Chủ nhật 19/07/2020 4:55 pm

Em tìm mãi trên các diễn đàn không có addin chuyển font chữ ( unicode,abc,vni) trong words 64 bit, bác nào cao thủ VBA, viết addin này cho cộng đồng đi ạ.
Đầu trang
vansit
Bài viết: 2
Ngày tham gia: Thứ 5 23/07/2020 11:10 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by vansit » Thứ 5 23/07/2020 11:40 am

các pro cho giúp em với em có 1 văn bản viết bằng font chữ vn-Time và em muốn chuyển đổi tất cả ký hiệu ngoặc đơn hoặc ngoặc kép sàn font chữ khác thì có thể làm bằng code VBA được không? mong các pro giúp em với
Đầu trang
Hình đại diện của thành viêntrungtamcnc
Bài viết: 2
Ngày tham gia: Thứ 3 15/07/2014 4:39 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by trungtamcnc » Thứ 6 31/07/2020 2:39 pm

phongthandell đã viết:
Nhờ bác chỉ dùm! Chuyển trắc nghiệm trên trang word, các câu đó nằm trong khung kẻ chuyển về dạng bình thường có đánh đáp án đúng ở mỗi câu! (Xem file đính kèm dùm)
Xin bác giúp dùm cháu!
Bạn còn cần nữa không?
Sub TablesToText()
Dim tabl As Table
For Each tabl In ActiveDocument.Tables
tabl.ConvertToText wdSeparateByTabs
Next
End Sub
Đầu trang
Hoc_Office
Bài viết: 1
Ngày tham gia: Thứ 3 13/10/2020 11:13 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Hoc_Office » Thứ 3 13/10/2020 11:39 am

Nhờ Bác viết dùm 1 macro tự động chạy các đường Link trong file Word.
Ví dụ: trong file tôi có 10 đường link.
Tôi muốn khi mở file đó thì macro nó tự động chạy tất cả các đường Link đó, nghỉ 3' rồi lại chạy từ đầu... Cảm ơn Bác nhiều.
TẬP TIN ĐÍNH KÈM
Tự-động-chạy-Link.rar
(14.78 KiB) Đã tải về 34 lần
Đầu trang
dongkisot84
Bài viết: 1
Ngày tham gia: Thứ 7 27/10/2018 9:19 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by dongkisot84 » Thứ 3 24/11/2020 10:53 am

Em có 1 file excel hỗ trợ copy bảng số liệu sang word nhưng đang gặp vấn đề là: Đối với số liệu dữ liệu number khi copy sang word sẽ hiện thêm các khoảng trắng, em muốn dùng VBA để xóa các đối tượng này, nhưng tham khảo 1 số nơi mà chưa tìm được, em mới nghiên cứu VBA nên không rành lắm, nhờ mọi người hỗ trợ code với
https://drive.google.com/file/d/1zde2bV ... sp=sharing
Đầu trang
207 bài viết    …    10  
Quay về
Trang chủDiễn đànThời gian được tính theo giờ UTC+07:00 UTC+7Xoá cookie của websiteLiên hệ chúng tôi
Đã tích hợp phpBB® Forum Software © phpBB Limited

Vietnamese language pack for phpBB 3.2.x download and support.

PRIVACY_LINK | TERMS_LINK


Page 11


Câu lạc bộ Visual Basic
.:: Nơi trao đổi về ngôn ngữ Visual Basic ::.

Bỏ qua nội dung

Nhập từ khóa tìm kiếm…
Đường dẫn nhanhTrợ giúpĐăng nhập
Trang chủDiễn đànTHẮC MẮC - TRAO ĐỔI - THẢO LUẬNVisual Basic for Application (VBA)
Trao đổi về Word VBA Mời vào đây!
Điều hành viên: tungblt

Nội quy chuyên mục

Tìm kiếm trong chủ đề này…
207 bài viết    …     11
thuanoez
Bài viết: 2
Ngày tham gia: Thứ 6 25/12/2020 8:58 am
Thay thế và thêm từ trong word
Gửi bài by thuanoez » Thứ 6 25/12/2020 9:11 am

Ke hoach giải ngân- yeu cau (1).rar
(25.86 KiB) Đã tải về 25 lần
Kính hỗ trợ VBA cho word. Yêu cầu:
1. Thay thế Số: /BQL-KHTH thành hashtag #SoKyHieuVanBan
2. Thay thế Quảng Ngãi, ngày tháng năm.... thành #DiaDiemNgayBanHanh
3. Thêm hashtag #ChuKyLanhDao phía dưới Trưởng Ban
3. Chuyển đổi thành file pdf sau khi đã gắn thêm 03 hashtag nêu trên.
Trân trọng cảm ơn.
Đầu trang
Lamnbk
Bài viết: 1
Ngày tham gia: Thứ 2 05/04/2021 9:17 am
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Lamnbk » Thứ 2 05/04/2021 9:25 am

Em có một vấn đề muốn hỏi bác:
Em có văn bản là một loạt các bài tập dạng: Bài 1, Bài 2, ...
Bây giờ em muốn làm code để chuyển tên Bài 1, Bài 2, .. thành đánh số tự động trong Word thì làm ntn ạ?
Đầu trang
Hình đại diện của thành viêntruongphu
VIP
VIP
Bài viết: 4785
Ngày tham gia: Chủ nhật 04/11/2007 10:57 am
Đến từ: Cam Đức, Khánh hòa
Has thanked: 14 times
Been thanked: 531 times
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by truongphu » Thứ 3 06/04/2021 12:03 pm

Lamnbk đã viết: ↑Thứ 2 05/04/2021 9:25 am
code để chuyển tên Bài 1, Bài 2, .. thành đánh số tự động trong Word
Thật lâu ngày ghé vào thăm clbvb.

Câu hỏi của bạn Lamnbk, tôi đoán là bạn thắc mắc làm sao Word tìm ra khi đối tượng tìm thay đổi như Bài 1, rồi Bài 2...

1- Bạn phải nắm kỹ code để Word.Selection.Find để tìm
2- Đương nhiên dùng .MatchWildcards = True

Vì dùng Wildcards, nên code tìm đối tượng biến đổi của bạn như sau:
Find: (Bài )([0-9]{1,})

Code gồm 2 nhóm (), nhóm 1 là (Bài ), Nhóm 2 là ([0-9]{1,}) mà ý nghĩa: [0-9] là ký tự số, {1,} là tối thiểu 1 ký tự.
Còn đánh số tự động, bạn chỉ cần cho một biến, và tăng dần. Vd:

Dim SoTDong&: SoTDong = 1
Find: (Bài )([0-9]{1,} ) ) Replace: SoTDong
SoTDong = SoTDong + 1
o0o--truongphu--o0o

.........
Ghé thăm:
Chuyện Linh Tinh
Đầu trang
Tran Vu
Bài viết: 1
Ngày tham gia: Thứ 3 27/04/2021 1:52 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by Tran Vu » Thứ 3 27/04/2021 2:31 pm

Chào bác Phú.
Em tên là Thế Vũ. Tài khoản trên forum là Tran Vu.
Qua những bài chia sẻ của bác Phú trên diễn đàn em thấy rất hay. Em cũng đang cần xuất dự liệu từ file Excel lên file word nhưng không biết trình bày như thế nào cho chính xác. Em muốn xin phép liên hệ trực tiếp với bác Phú để học tập ah.
Nếu được, bác Phú cho em xin thông tin nhé. Zalo/viber của em: 0909013057.
Em cảm ơn bác Phú và cả nhà ah.
P/s: Em thấy bác ghi : Đến từ Cam Đức. Còn quê em ở Ba Ngòi, Cam Ranh ah.
Đầu trang
thuanoez
Bài viết: 2
Ngày tham gia: Thứ 6 25/12/2020 8:58 am
Re: Thay thế và thêm từ trong word
Gửi bài by thuanoez » Thứ 5 01/07/2021 10:42 am

thuanoez đã viết: ↑Thứ 6 25/12/2020 9:11 am
Ke hoach giải ngân- yeu cau (1).rarKính hỗ trợ VBA cho word. Yêu cầu:
1. Thay thế Số: /BQL-KHTH thành hashtag #SoKyHieuVanBan
2. Thay thế Quảng Ngãi, ngày tháng năm.... thành #DiaDiemNgayBanHanh
3. Thêm hashtag #ChuKyLanhDao phía dưới Trưởng Ban
3. Chuyển đổi thành file pdf sau khi đã gắn thêm 03 hashtag nêu trên.
Trân trọng cảm ơn.
Bác Trường Phú (Phú Trường) hỗ trợ em với ạ
Đầu trang
haibh
Bài viết: 1
Ngày tham gia: Thứ 2 09/08/2021 4:29 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by haibh » Thứ 2 09/08/2021 4:45 pm

Hình ảnhHỏi lập trình
- từ file ảnh hình 1, tạo một form nhập số liệu vào ô màu trắng
- các ô khác tạo nút lệnh
+ ô 3,4 cấu tử: viết lệnh lựa chọn nguyên liệu
vi dụ: đá vôi, đất sét, quăng sắt, coal cid, khi cho 3 cấu tử sẽ ẩn đi 1 nguyên liệu.
- các ô update là cập nhật số liệu của một loại nguyên liệu khi ta nhập vào
- Ô Delete xoa toàn bộ dữ liệu trong bảng
- ô reset là dùng reset lại tính toán (hình 2 )
- ô calculate để dùng tính toán, kết quả tính toán sẽ
đưa ra ở bảng số 2 (hình 2 )
bảng (hình 2 sẽ hiện ra ) sau khi nhấn nút calculate
Tôi mơi học lên chưa thành thạo
mong bạn chỉ giúp tạo hộ tôi vơi điều kiện viết ở bên
ở file tôi đã viết trên VBA excel rồi
tôi muôn đưa ra bảng như trên để thuận tiện, không phỉa mở excel ra
Hình ảnh[][/url[/img]]
TẬP TIN ĐÍNH KÈM
Picture3.jpg
Picture3.jpg (81.09 KiB) Đã xem 126 lần
Picture2.jpg
Picture3.jpg
Picture3.jpg (81.09 KiB) Đã xem 126 lần
Đầu trang
hlacom
Bài viết: 1
Ngày tham gia: Thứ 3 31/08/2021 5:03 pm
Re: Trao đổi về Word VBA Mời vào đây!
Gửi bài by hlacom » Thứ 3 31/08/2021 5:09 pm

Tìm kiếm và thay thế kèm điều kiện:
Mong các bác giúp: em có 1 dòng thế này:
A. Trứng gà.
Trong đó "trứng gà" đã highliht còn "A. " thì không highlight.
Yêu cầu: tìm các dòng đã có từ hoặc một số từ highlight thì highlight cả dòng ! rất mong sự giúp đỡ!
Đầu trang
207 bài viết    …     11
Quay về
Trang chủDiễn đànThời gian được tính theo giờ UTC+07:00 UTC+7Xoá cookie của websiteLiên hệ chúng tôi
Đã tích hợp phpBB® Forum Software © phpBB Limited

Vietnamese language pack for phpBB 3.2.x download and support.

PRIVACY_LINK | TERMS_LINK