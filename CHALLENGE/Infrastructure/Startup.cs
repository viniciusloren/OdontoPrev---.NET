using CHALLENGE.Application;
using CHALLENGE.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration; 
    }

    public void ConfigureServices(IServiceCollection services)
    {
        // Configura o contexto do banco de dados
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        // Registra os repositórios
        services.AddScoped<IPacienteRepository, PacienteRepository>();
        services.AddScoped<ISinistroRepository, SinistroRepository>(); // Adicione esta linha
        services.AddScoped<PrevisaoSinistroService>();

        // Adiciona serviços de controladores
        services.AddControllers(); // Adicione esta linha

        // Adiciona serviços de autorização
        services.AddAuthorization(); // Mantenha esta linha
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error"); 
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        // Certifique-se de que a autenticação é chamada se necessário
        // app.UseAuthentication(); // Descomente se estiver usando autenticação

        app.UseAuthorization(); // Mantenha esta linha

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers(); 
        });
    }
}