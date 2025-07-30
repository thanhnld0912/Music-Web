using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// Khởi tạo builder
var builder = WebApplication.CreateBuilder(args);

// Đăng ký dịch vụ vào DI container
builder.Services.AddControllersWithViews();

// Đăng ký các service nghiệp vụ
builder.Services.AddScoped<IApplicationUserService, ApplicationUserService>();
builder.Services.AddScoped<ICommentReportService, CommentReportService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IDislikeService, DislikeService>();
builder.Services.AddScoped<IFollowService, FollowService>();
builder.Services.AddScoped<ILikeService, LikeService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IPlaylistService, PlaylistService>();
builder.Services.AddScoped<IPlaylistSongService, PlaylistSongService>();
builder.Services.AddScoped<IPostReportService, PostReportService>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IRecentPlayService, RecentPlayService>();
builder.Services.AddScoped<ISongService, SongService>();
builder.Services.AddScoped<IUserService, UserService>();

// Build app
var app = builder.Build();

// Middleware pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Cấu hình route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Chạy ứng dụng
app.Run();
