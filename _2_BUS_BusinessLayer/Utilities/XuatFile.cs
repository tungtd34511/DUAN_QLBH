using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.Models;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using OfficeOpenXml.Style;


namespace _2_BUS_BusinessLayer.Utilities
{
    public class XuatFile
    {
        private ExcelPackage p;
        public string Export_to_Excel(string title, string filePath, List<SanPham> list)
        {
            try
            {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            p = new ExcelPackage(new FileInfo(title+".xlsx"));
                // đặt tên người tạo file
                p.Workbook.Properties.Author = "Eagle shop";

                // đặt tiêu đề cho file
                p.Workbook.Properties.Title = title;

                //Tạo một sheet để làm việc trên đó
                p.Workbook.Worksheets.Add("sheet1");

                // lấy sheet vừa add ra để thao tác
                ExcelWorksheet ws = p.Workbook.Worksheets[0];

                // đặt tên cho sheet
                ws.Name = "sheet1";
                // fontsize mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 11;
                // font family mặc định cho cả sheet
                ws.Cells.Style.Font.Name = "Calibri";
                // Tạo danh sách các column header
                string[] arrColumnHeader =
                {
                    "ID","Mã QR","Tên", "Giới tính", "Nhóm hàng", "Thương hiệu", "Chất liệu", "Tổng quan", "Giá bán", "Giá nhập",
                    "Phiên bản (màu_size_số lượng)","Trạng thái", "Ảnh",
                };

                // lấy ra số lượng cột cần dùng dựa vào số lượng header
                var countColHeader = arrColumnHeader.Count();

                // merge các column lại từ column 1 đến số column header
                ws.Cells[1, 1].Value = title+" ngày "+DateTime.Today.ToShortDateString();
                ws.Cells[1, 1, 1, countColHeader].Merge = true;
                // in đậm
                ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                //
                ws.Cells[1, 1, 1, countColHeader].Style.Font.Size = 35;
                //
                ws.Cells.Style.JustifyLastLine = false; 
                // căn giữa
                ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                int colIndex = 1;
                int rowIndex = 2;

                //tạo các header từ column header đã tạo từ bên trên
                foreach (var item in arrColumnHeader)
                {
                    var cell = ws.Cells[rowIndex, colIndex];

                    //set màu thành gray
                    var fill = cell.Style.Fill;
                    fill.PatternType = ExcelFillStyle.Solid;
                    fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                    //căn chỉnh các border
                    var border = cell.Style.Border;
                    border.Bottom.Style =
                        border.Top.Style =
                            border.Left.Style =
                                border.Right.Style = ExcelBorderStyle.Thin;

                    //gán giá trị
                    cell.Value = item;

                    colIndex++;
                }
                
                //"Tên", "Giới tính", "Nhóm hàng", "Thương hiệu", "Chất liệu", "Tổng quan", "Giá bán", "Giá nhập",
                //"Phiên bản", "Ảnh"
                var List = from p in list
                    select new
                    {
                        MaSp = p.Product.Id.ToString(),
                        MaQR = p.ProductDetail.QrCode.ToString(),
                        ten = p.Product.Name,
                        gioitinh = p.ProductDetail.Sex == true?"Nam":"Nữ",
                        nhomhang = p.Catergory.Name,
                        thuonghieu = p.ThuongHieu.Name,
                        chatlieu = p.ProductDetail.ChatLieu,
                        tongquan = p.ProductDetail.MoTaChiTiet,
                        giaban = p.Price.GiaBan.ToString().Split(".").FirstOrDefault(),
                        gianhap = p.Price.GiaNhap.ToString().Split(".").FirstOrDefault(),
                        phienbans = (from s in p.Vers
                                select new
                                {
                                    ver = p.Colors.FirstOrDefault(c=>c.Id == s.ColorId).ColorCode+"_"+ p.Sizes.FirstOrDefault(c => c.Id == s.SizeId).Code +"_"+s.SoLuong
                                }),
                        anhs = p.Images.Select(c=>c.Path),
                        tinhtrang = p.Product.Status ==true?"Đang mở bán":"Ngưng kinh doanh"
                    };

                // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                foreach (var item in List)
                {
                    // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                    colIndex = 1;

                    // rowIndex tương ứng từng dòng dữ liệu
                    rowIndex++;

                    //gán giá trị cho từng cell 
                    ws.Cells[rowIndex, colIndex++].Value = item.MaSp;
                    ws.Cells[rowIndex, colIndex++].Value = item.MaQR;
                    ws.Cells[rowIndex, colIndex++].Value = item.ten;
                    ws.Cells[rowIndex, colIndex++].Value = item.gioitinh;
                    ws.Cells[rowIndex, colIndex++].Value = item.nhomhang;
                    ws.Cells[rowIndex, colIndex++].Value = item.thuonghieu;
                    ws.Cells[rowIndex, colIndex++].Value = item.chatlieu;
                    ws.Cells[rowIndex, colIndex++].Value = item.tongquan;
                    ws.Cells[rowIndex, colIndex++].Value = item.giaban;
                    ws.Cells[rowIndex, colIndex++].Value = item.gianhap;

                    string phienban = "";
                    foreach (var x in item.phienbans)
                    {
                        phienban += x.ver + "\n";
                    }
                    ws.Cells[rowIndex, colIndex++].Value = phienban;
                    ws.Cells[rowIndex, colIndex++].Value = item.tinhtrang;
                    string anh = "";
                    foreach (var x in item.anhs)
                    {
                        anh += x + "\n";
                    }
                    ws.Cells[rowIndex, colIndex++].Value = anh;
                }
                ws.Cells.AutoFitColumns();
                ws.Cells.Style.WrapText = true;
                //Lưu file lại
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(filePath, bin);
                return "Xuất excel thành công!";
            }
            catch
            {
                return "Có lỗi khi lưu file!";
            }
        }
    }
}
