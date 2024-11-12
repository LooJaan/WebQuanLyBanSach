using AppData;
using AppData.Repositories;
using AppData.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Đăng ký các Repository
builder.Services.AddScoped<IVaiTroRepository, VaiTroRepository>();
builder.Services.AddScoped<IKhachHangRepository, KhachHangRepository>();
builder.Services.AddScoped<INhanVienRepository, NhanVienRepository>();
builder.Services.AddScoped<ISachRepository, SachRepository>();
builder.Services.AddScoped<ITheLoaiRepository, TheLoaiRepository>();
builder.Services.AddScoped<INgonNguRepository, NgonNguRepository>();
builder.Services.AddScoped<INhaXuatBanRepository, NhaXuatBanRepository>();
builder.Services.AddScoped<ISachCTRepository, SachCTRepository>();
builder.Services.AddScoped<IHoaDonRepository, HoaDonRepository>();
builder.Services.AddScoped<IHoaDonCTRepository, HoaDonCTRepository>();
builder.Services.AddScoped<IPhieuNhapRepository, PhieuNhapRepository>();
builder.Services.AddScoped<INhaCungCapRepository, NhaCungCapRepository>();
builder.Services.AddScoped<IPhieuNhapCTRepository, PhieuNhapCTRepository>();
builder.Services.AddScoped<ITacGiaRepository, TacGiaRepository>();
builder.Services.AddScoped<IDonHangRepository, DonHangRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IChiTietDonHangRepository, ChiTietDonHangRepository>();



// Đăng ký các Service
builder.Services.AddScoped<IVaiTroService, VaiTroService>();
builder.Services.AddScoped<IKhachHangService, KhachHangService>();
builder.Services.AddScoped<INhanVienService, NhanVienService>();
builder.Services.AddScoped<ISachService, SachService>();
builder.Services.AddScoped<ITheLoaiService, TheLoaiService>();
builder.Services.AddScoped<INgonNguService, NgonNguService>();
builder.Services.AddScoped<INhaXuatBanService, NhaXuatBanService>();
builder.Services.AddScoped<ISachCTService, SachCTService>();
builder.Services.AddScoped<IHoaDonService, HoaDonService>();
builder.Services.AddScoped<IHoaDonCTService, HoaDonCTService>();
builder.Services.AddScoped<IPhieuNhapService, PhieuNhapService>();
builder.Services.AddScoped<INhaCungCapService, NhaCungCapService>();
builder.Services.AddScoped<IPhieuNhapCTService, PhieuNhapCTService>();
builder.Services.AddScoped<IChiTietDonHangService, ChiTietDonHangService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IDonHangService, DonHangService>();
builder.Services.AddScoped<ITacGiaService, TacGiaService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
