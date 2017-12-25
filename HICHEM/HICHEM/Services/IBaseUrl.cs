using System;
namespace HICHEM.Services
{
  public interface IBaseUrl
  {
    String Get(String path);

    void LongAlert(string message);
    void ShortAlert(string message);
  }
}
