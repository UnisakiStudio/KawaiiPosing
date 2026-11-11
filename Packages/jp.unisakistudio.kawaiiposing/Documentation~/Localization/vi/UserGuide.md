# Kawaii Posing Tool — Hướng dẫn người dùng tiếng Việt

Kawaii Posing cung cấp 85 tư thế cho chế độ máy tính và VR ba điểm: 15 đứng, 20 ngồi xổm/ghế, 17 ngồi sàn, 17 nằm ngửa và 16 nằm sấp.

Hướng dẫn này gồm cài đặt, thiết lập avatar, điều khiển VRChat, sửa tư thế, cập nhật và khắc phục sự cố. ZIP đã mua có `START_HERE.html` để đến phần cài đặt nhanh nhất.

## Trước khi bắt đầu

- Dùng dự án **avatar** VRChat Unity 2022.3 được tạo hoặc quản lý bằng VRChat Creator Companion (VCC) hay ALCOM.
- Gói yêu cầu: VRChat Avatars SDK 3.10.4 trở lên; Modular Avatar 1.x, phiên bản 1.15.1 trở lên; NDMF 1.x, phiên bản 1.14.0 trở lên.
- Công cụ dành cho avatar Humanoid ở chế độ máy tính và VR ba điểm (kính và hai bộ điều khiển). Không hỗ trợ khóa tư thế khi theo dõi toàn thân đang bật.
- Sao lưu dự án hiện có trước cài/cập nhật. Xử lý hết lỗi biên dịch Unity trước.
- Trình cài tải sản phẩm và gói phụ thuộc từ kho gói tương ứng, cần internet. Mô hình avatar, VRChat SDK, Modular Avatar và NDMF không nằm trong ZIP này.

## 1. Cài giấy phép và sản phẩm

1. Giải nén toàn bộ ZIP vào thư mục thường bên ngoài dự án Unity.
2. Mở dự án avatar đích trong Unity. Nhập `Installer/KawaiiPosing_Installer.unitypackage` bằng **Assets > Import Package > Custom Package**, hoặc mở tệp bằng Unity.
3. Đọc thông báo nhập và cài đặt. Xác nhận giấy phép giải thích giấy phép sản phẩm nào sẽ được cài. Dùng **Ngôn ngữ…** (hoặc **言語...**) trong hộp thoại xác nhận để đổi ngôn ngữ trình cài.
4. Xác nhận cài giấy phép. Giấy phép cũng bao gồm Unisaki Posing System chung dùng bởi sản phẩm. Trình cài có thể đề nghị xóa tệp thiết lập của nó sau đó; dọn dẹp này không xóa giấy phép sản phẩm đã cài.
5. Xem xác nhận trình cài gói tự động. Nó liệt kê gói/kho sẽ thêm và tệp/thư mục cũ dự định xóa. Tiếp tục nếu đúng các mục bạn muốn.
6. Đợi Unity nhập và biên dịch xong. Nếu cài gói không tự hoàn tất, mở dự án bằng VCC hoặc ALCOM và thêm **Kawaii Posing Tool**, **Modular Avatar**. **Unisaki Posing System** chung và **NDMF** là gói phụ thuộc. `Optional-VCC-Links` chứa lối tắt kho gốc đi kèm sản phẩm dành cho người dùng VCC Windows.
7. Nếu đã hủy xác nhận, nhập lại trình cài khi sẵn sàng. Bạn cũng có thể dùng lệnh cài giấy phép trong **Tools > Unisaki Studio** khi trình kích hoạt vẫn còn. Ở bản dựng cũ, menu con này tên **ゆにさきスタジオ**.

### Bản tải này cài những gì

**Kawaii Posing Tool 3.2.0 với Unisaki Posing System 3.2.0.** Phiên bản đang phát triển và chưa phát hành. Bổ sung hộp thoại cài đặt, Inspector/menu Unity, tên tư thế chuẩn, menu trò chơi và tài liệu ngoại tuyến bằng ba mươi ngôn ngữ. Chưa xác định ngày phát hành. Dùng bộ chọn ngôn ngữ đầu Inspector để đổi ngôn ngữ công cụ. Sau công bố, trình cài sẽ tải các phiên bản này và phụ thuộc tương thích từ kho VPM. Chuẩn bị phát hành cục bộ không công bố các gói đó.

Kawaii Posing Tool gồm thư viện tư thế, công cụ cấu hình và thiết lập sẵn hiệu chỉnh avatar. Trình cài kích hoạt giấy phép cục bộ hiện có; không yêu cầu ô khóa giấy phép Gumroad mới. Không bao giờ đăng tệp trình cài hoặc dữ liệu giấy phép trong yêu cầu hỗ trợ công khai.

Tùy chọn ngôn ngữ lưu qua Unity EditorPrefs cho người dùng hệ điều hành hiện tại và dùng chung giữa dự án Unity trên máy này. Nếu chưa lưu lựa chọn, trình cài theo ngôn ngữ hệ điều hành; ngôn ngữ không hỗ trợ dùng tiếng Anh. Giấy phép sản phẩm giữ nơi lưu hiện có: khóa registry `Software/UnisakiStudio` của người dùng hiện tại trên Windows và tệp giấy phép riêng người dùng trên macOS/Linux. Đổi ngôn ngữ không xóa giấy phép. Tất cả công cụ tạo dáng và avatar dùng chung một ngôn ngữ. Thay đổi trong Inspector của bất kỳ công cụ nào sẽ cập nhật tùy chọn chung; lựa chọn ngôn ngữ riêng của từng avatar không được sử dụng. Nút ngôn ngữ chỉ xuất hiện ở bước xác nhận cài đặt đầu tiên khi chưa lưu ngôn ngữ. Các lần đổi ngôn ngữ sau được thực hiện trong Inspector.

## 2. Thêm công cụ vào avatar

1. Trong **Hierarchy**, chọn avatar có **VRC Avatar Descriptor**, hoặc một đối tượng con. Dùng avatar đã đặt trong Scene, không dùng tài nguyên prefab ở cửa sổ Project hay Prefab Mode.
2. Nhấp phải avatar và chọn **Unisaki Studio > Thêm Kawaii Posing**. Nếu bản đã cài dùng menu Nhật, chọn **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Công cụ được thêm bên trong avatar. Tên đối tượng đã lưu có thể vẫn là **可愛いポーズ** dù nhãn hiển thị được dịch.
4. Nếu có đề nghị thiết lập sẵn khớp avatar, áp dụng làm điểm khởi đầu. Nếu không, mở **Thiết lập avatar** và chọn thiết lập sẵn hoặc tự hiệu chỉnh tư thế.
5. Trình cài có thể đề nghị tạo trước. Tạo trước là tùy chọn; dựng avatar thường cũng sinh dữ liệu cần thiết. Tái dùng dữ liệu tạo trước để giảm thời gian dựng sau.
6. Chọn đối tượng công cụ, chọn tư thế/tính năng muốn dùng rồi tải avatar lên như thường qua VRChat SDK.

### Chọn ngôn ngữ và nhãn quen thuộc

Phiên bản này có **Language / 言語** ở đầu Inspector công cụ. Một lựa chọn điều khiển cả Inspector và menu trò chơi được tạo. Avatar lưu ngôn ngữ đã chọn; lựa chọn gần nhất được nhớ cho công cụ/dự án khác trên máy này. Tải avatar lên lại để đổi ngôn ngữ thấy trong VRChat.

Dùng bảng nhãn dưới đây khi làm theo hướng dẫn tiếng Nhật cũ. Phiên bản có bộ chọn ngôn ngữ, Inspector được bản địa hóa, tên tư thế chuẩn được dịch và menu trò chơi cho cả 30 ngôn ngữ.

| Nhãn tiếng Việt | Nhãn tiếng Nhật ở bản cũ |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Tính năng | 機能 |
| Tư thế | ポーズ一覧 |
| Thiết lập avatar | アバター調整 |
| Mở thiết lập | 設定を開く |
| Cập nhật dữ liệu tạo trước | プレビルドを更新 |
| Kiểm tra thiết lập | 設定の確認 |
| Xem trước | プレビュー |
| Hiệu chỉnh hoạt ảnh | アニメーション調整 |
| Tải lại | 再読込 |

Inspector, hộp thoại chỉnh sửa/cài đặt, tên tư thế chuẩn và menu được tạo có bản dịch cho cả 30 ngôn ngữ có thể chọn. README, lịch sử thay đổi và hướng dẫn ngoại tuyến được cung cấp cho từng ngôn ngữ. Tên avatar, tên đối tượng đã lưu, tên tư thế tùy chỉnh, tên tệp tài nguyên và mã định danh tham số nội bộ có thể giữ cách viết gốc.

[Tham khảo nhanh 30 ngôn ngữ](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) gồm giải thích tính năng và bảng tên tư thế chuẩn. Đây là tài liệu ngắn gọn; dùng mục lục ngôn ngữ để đọc tài liệu đầy đủ.

## 3. Chọn tư thế và tính năng

Inspector có ba thẻ chính:

| Thẻ | Dùng cho |
| --- | --- |
| **Tính năng** | Điều khiển menu trò chơi, hành vi tùy chọn, thở, tùy chọn biểu tượng và mức dùng tham số biểu cảm. |
| **Tư thế** | Tư thế bật, loại/tìm kiếm, thứ tự, thêm hoạt ảnh, xem trước, chi tiết và hiệu chỉnh hoạt ảnh. |
| **Thiết lập avatar** | Hiệu chỉnh riêng avatar/gối, nhập chuyển động gốc/tùy chỉnh và thiết lập sẵn. |

Chỉ bật điều khiển menu bạn định dùng. Ví dụ, thêm **Lật đối xứng** vào menu cho phép chuyển lật trong VRChat, không buộc mọi tư thế luôn lật.

Kawaii Posing gồm thiết lập sẵn avatar và IK cho tư thế hỗ trợ. Ba tư thế nằm ngửa chuẩn đã gán chuyển động nằm nghiêng: **Duỗi chân (足伸ばし)**, **Thư thái (リラックス)** và **Co một gối (膝立て)**. Dùng thiết lập sẵn phù hợp và kiểm tra Lật người của từng tư thế nếu đã sửa/thay các mục này.

### Thiết lập sẵn và chỉnh cho vừa

Thiết lập sẵn ở gần cuối **Thiết lập avatar**. Tìm theo tên avatar rồi áp dụng để thay thiết lập tư thế hiện tại. Lưu hoặc sao lưu hiệu chỉnh trước đổi. Thiết lập sẵn chỉ là điểm khởi đầu: vóc dáng, trang phục và chỉnh sửa avatar vẫn có thể cần sửa thủ công.

Dùng **Hiệu chỉnh hoạt ảnh** trên tư thế để xem trước và sửa vị trí thân/chi. Lưu hoạt ảnh hiệu chỉnh từ cửa sổ đó khi xong. Khi hỗ trợ, hiệu chỉnh tay/chân tự động (IK) bật được toàn bộ và từng tư thế. Ghi kết quả IK hiện tại vào hiệu chỉnh tạo hoạt ảnh hiệu chỉnh và tắt IK tư thế đó để bạn hoàn thiện thủ công; clip nguồn gốc được giữ.

**Ngăn đầu gối gập ngược** có thiết lập bổ sung như góc gập gối tối thiểu. Hiệu chỉnh riêng avatar chỉ có khi tồn tại dữ liệu tương ứng; một số không kết hợp được với IK tư thế.

### Chuyển động gốc và tùy chỉnh

**Dùng tư thế đứng, ngồi xổm và nằm sấp gốc** phát hiện chuyển động từ layer Base avatar khi tạo dữ liệu. **Dùng chuyển động riêng** mở thiết lập nhập riêng từng loại. Chọn một chuyển động mỗi loại. Chỉ định thủ công ưu tiên hơn nhập tự động cho loại đó.

Nhập tự động áp dụng cho bản sao dựng, không ghi hoạt ảnh phát hiện vào danh sách thủ công của Scene hay sửa Controller gốc. Xóa chỉ định thủ công của loại muốn tự phát hiện lại. Layer Base tùy chỉnh và hệ thống di chuyển khác có thể cần hiệu chỉnh riêng.

## 4. Dùng công cụ trong VRChat

Mở menu **Expressions** của avatar và vào **Kawaii Posing**. Chọn một tư thế cho mỗi loại muốn dùng. Chọn tư thế và chọn tính năng là hai thao tác riêng.

- **VR ba điểm:** hạ/nâng đầu để đổi đứng, ngồi xổm/ghế, ngồi sàn và nằm. Chỉnh ngưỡng cao trong menu công cụ nếu chuyển quá sớm hoặc muộn.
- **Máy tính:** dùng **C** để ngồi xổm và **Z** để nằm. Nếu Z vẫn chỉ ngồi, tăng ngưỡng độ cao nằm trong menu thiết lập.
- **Nằm sấp/ngửa:** công cụ dùng hướng mặt để chọn nằm sấp hoặc ngửa. Nếu chọn cả hai, nhảy tại chỗ có thể chuyển. Tắt đổi bằng nhảy trong **Tính năng > Tiện ích** của Unity nếu muốn; tính năng không dùng thêm tham số đồng bộ.
- **Khóa:** dùng khóa đầu, tay, chân khi cần. Tắt cử chỉ nếu muốn hình bàn tay tư thế thay input cử chỉ bộ điều khiển.
- **Lật đối xứng:** lật tư thế đã chọn để quay về bạn bè hoặc khớp bố cục.

### Độ cao chân và Độ cao sàn

**Độ cao chân** chỉnh chân trong khi giữ đầu. Dùng khi chân nổi/chìm mà đầu đã đúng độ cao.

**Độ cao sàn** di chuyển toàn thân, gồm đầu. Dùng cho sofa, giường hay bề mặt cao, cả đồ nội thất không có collider. Trên điều khiển lấy giữa làm gốc hiện tại của hệ thống chung, **50% là độ cao gốc**, 0% thấp hơn 3 m và 100% cao hơn 3 m. Đưa về gần 50% để kết thúc độ lệch. Bản cũ có thể điều khiển khác; kiểm tra phiên bản đã cài và cập nhật hệ thống chung cùng sản phẩm.

### Chế độ chụp

Bật mục menu **Chế độ chụp** trong Unity trước tải lên. Trong VRChat, chọn tư thế, dùng **Khoảng cách** tiến tối đa 3 m và **Hướng** để xoay avatar. Khóa chân là tùy chọn khi bố trí ảnh. **Thoát chụp** đặt lại khoảng cách/góc xoay và mở khóa chân.

Chế độ chụp mặc định chỉ cục bộ. Để người khác thấy vị trí và góc xoay, bật **Đồng bộ chế độ chụp** trong Unity trước tải lên; dùng 16 bit đồng bộ. **Giữ đầu hiển thị trong chế độ chụp** ảnh hưởng góc nhìn của bạn và không dùng bit đồng bộ.

### Thở và Lật người

Đặt thở từng loại tư thế tại **Tính năng > Tiện ích > Thêm hoạt ảnh thở**. Chọn Không, Nhẹ, Vừa, Mạnh, Nhanh hoặc hoạt ảnh thở Tùy chỉnh. Chuyển động không dùng bit đồng bộ. Công tắc menu thở dùng 1 bit.

Lật người cần tư thế nằm hỗ trợ và mục menu **Lật người**. Bật cho tư thế và cung cấp hoạt ảnh nghiêng khi cần. Trong VRChat, chọn tư thế đó, bật Lật người rồi mở khóa đầu/cổ. Độ nghiêng đầu sang bên điều khiển lật. MotionTime thường không dùng được cho tư thế đó khi dùng Lật người.

Ba tư thế nằm ngửa chuẩn nói trên có sẵn chuyển động nghiêng. Tư thế khác cần chuyển động và thiết lập phù hợp. Thiết lập sẵn nhập/tùy chỉnh có thể gán khác.

## 5. Sửa, thêm và xem trước tư thế

Trong **Tư thế**, chọn loại hoặc thẻ tìm kiếm. Tìm được tên Nhật gốc và bản dịch có sẵn. Mở **Chi tiết** tư thế để sửa hoạt ảnh, biểu tượng, thứ tự và tùy chọn thời gian.

Để thêm nhiều hoạt ảnh, kéo clip vào vùng thêm hoặc chọn clip trong Project rồi dùng lệnh nhập clip đã chọn. Tham chiếu trùng tới cùng clip được bỏ. Đổi vị trí đích trong Chi tiết hoặc dùng nút lên/xuống.

**Xem trước** hiển thị tư thế trong Scene mà không mở cửa sổ hiệu chỉnh đầy đủ. Xem trước nhẹ không chạy Modular Avatar hay NDMF, nên kiểm tra trang phục, hiệu chỉnh sàn và tính năng lúc dựng trong bản dựng avatar cuối.

Biểu tượng tư thế tạo từ avatar giúp nhận diện, nhưng tạo tốn thời gian và có thể tăng dung lượng avatar. Giảm độ phân giải để tiết kiệm. Bản Android không tạo biểu tượng tư thế. Tạo lại sau đổi avatar/trang phục khi cần.

## 6. Bộ nhớ tham số

Inspector hiển thị phần của công cụ tư thế, không phải tổng toàn avatar. Trang phục và hệ thống khác có thể dùng thêm bộ nhớ. Thiết lập chung nhiều công cụ không tính hai lần. Cấu hình tùy chỉnh có nhiều tư thế thêm có thể cần nhiều bit chọn tư thế hơn.

| Tính năng | Bit đồng bộ thêm |
| --- | ---: |
| Chọn tư thế, cấu hình chuẩn tối thiểu | 8 |
| Lật đối xứng | 1 |
| Tắt cử chỉ | 1 |
| Hoạt ảnh thở | 0 |
| Công tắc menu Thở | 1 |
| Độ cao chân | 8 |
| Độ cao sàn | 8 |
| Chế độ chụp, chỉ cục bộ | 0 |
| Đồng bộ chế độ chụp | 16 |
| Giữ đầu hiển thị trong chế độ chụp | 0 |
| Tắt đung đưa khi đứng yên của VRChat | 0 |
| Lật người | 10 |

Lật người dùng chung 1 bit với hiệu chỉnh tư thế theo hướng cổ: bật cả hai vẫn tổng 10 bit cho hai tính năng. Mức hiển thị trong phiên bản đã cài là tham khảo thực tế cho cấu hình đã chọn.

## 7. Cập nhật và tạo trước

1. Sao lưu dự án và lưu Scene đang làm.
2. Trong VCC hoặc ALCOM, cập nhật **Kawaii Posing Tool** và **Unisaki Posing System** chung cùng nhau. Giữ phiên bản SDK, Modular Avatar và NDMF cần thiết tương thích.
3. Đợi biên dịch xong. Chọn công cụ đã cài, kiểm tra tư thế, thiết lập và mức tham số.
4. Nếu dùng tạo trước, chọn **Cập nhật dữ liệu tạo trước** rồi tải avatar lên lại.

Thiết lập công cụ hiện có được giữ. Prefab 8-bit cũ giữ để tương thích; tham chiếu hiện có không đòi xóa/thay công cụ. Cài mới dùng prefab thường, và có thể tắt tính năng không dùng để giảm tham số.

Cảnh báo dữ liệu tạo trước cũ nghĩa là thiết lập đã đổi sau khi sinh dữ liệu cache. Cập nhật tạo trước sinh lại dữ liệu đó. Ẩn cảnh báo không cập nhật tạo trước hay giải quyết nguyên nhân. Dựng avatar thường vẫn tạo dữ liệu cần dù không tạo trước thủ công mỗi lần.

## 8. Khắc phục sự cố

| Triệu chứng | Cần kiểm tra |
| --- | --- |
| Không có menu thêm công cụ | Kiểm tra đã cài sản phẩm **và** Unisaki Posing System, xử lý lỗi biên dịch Console Unity. Chỉ trình cài giấy phép không phải thư viện tư thế. |
| Trình cài bị hủy hoặc tệp bị xóa | Nhập lại trình cài đã mua khi sẵn sàng. Đọc lại xác nhận. |
| Giấy phép có vẻ mất ở dự án khác | Nhập trình cài đã mua dưới cùng tài khoản hệ điều hành. Nếu đổi máy/tài khoản, cài giấy phép ở đó nữa. Tùy chọn ngôn ngữ không tự chuyển giữa máy. |
| Không có tư thế trong VRChat | Thêm công cụ dưới đúng avatar Scene, bật tư thế muốn dùng, xem cảnh báo Inspector rồi tải avatar đó lên. Kiểm tra SDK và công cụ di chuyển khác. |
| Z không chuyển sang nằm | Tăng ngưỡng độ cao nằm trong thiết lập công cụ ở trò chơi. |
| Tay hoặc gối không khớp | Thử thiết lập sẵn avatar tương ứng, rồi dùng IK hỗ trợ và/hoặc Hiệu chỉnh hoạt ảnh. Kiểm tra biến dạng trang phục trong bản dựng cuối. |
| Lật người không hoạt động | Dùng tư thế nằm hỗ trợ, bật cả thiết lập Lật người của tư thế và mục menu, mở khóa đầu/cổ. Trước tiên thử một trong ba tư thế chuẩn hỗ trợ. |
| Bạn bè không thấy chuyển động chụp | Bật **Đồng bộ chế độ chụp** trong Unity, kiểm tra tham số rồi tải lại. |
| Đổi ngôn ngữ trong Unity nhưng VRChat không đổi | Tải avatar lên lại. Kiểm tra bộ chọn ngôn ngữ duy nhất ở đầu Inspector trong bản có bản địa hóa. |
| Lỗi dựng/tạo trước | Đọc lỗi Console liên quan **đầu tiên**. Sao lưu Scene, cập nhật/tải lại sản phẩm và hệ thống chung qua VCC/ALCOM, liên hệ hỗ trợ nếu vẫn lỗi. Giữ đối tượng đã hiệu chỉnh và GeneratedResources trừ khi hỗ trợ chỉ bước khôi phục cụ thể. |

Khi liên hệ hỗ trợ, cung cấp phiên bản sản phẩm/hệ thống chung, Unity/SDK/Modular Avatar/NDMF, tên avatar, bước tái hiện chính xác và lỗi Console liên quan. Loại tệp riêng, nội dung trình cài, giá trị giấy phép và thông tin tài khoản khỏi bài đăng công khai.

- [Hỗ trợ](https://help.unisakistudio.jp/)
- [Hướng dẫn trực tuyến có minh họa (tiếng Nhật)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Trang sản phẩm Gumroad](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Giấy phép và ghi công

[Bản dịch tham khảo tiếng Anh của thỏa thuận sản phẩm](../../Terms.en.html) được cung cấp cùng thỏa thuận tiếng Nhật gốc.

Đọc thỏa thuận sản phẩm gốc và thỏa thuận hệ thống chung cạnh README gói hoặc trong thư mục `Licenses` của ZIP đã mua. Thỏa thuận Unisaki Posing System tiếng Anh đi kèm là bản dịch tham khảo hiện có của hệ thống; thỏa thuận tiếng Nhật sản phẩm vẫn cung cấp riêng. Hướng dẫn không thay đổi thỏa thuận hay cấp thêm quyền. Liên hệ hỗ trợ nếu hỏi về sử dụng/phân phối lại dữ liệu sản phẩm.

Trình cài gồm **VPMPackageAutoInstaller** đã chỉnh sửa của **anatawa12**, cùng **SimpleJson** và **semver.net**. Thông báo bản quyền và văn bản giấy phép MIT có trong `ThirdPartyNotices.txt` của ZIP đã mua. Thư viện tư thế và tài nguyên sản phẩm khác có giấy phép sản phẩm riêng.
