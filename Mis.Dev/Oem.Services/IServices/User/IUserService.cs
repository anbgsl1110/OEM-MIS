﻿using Oem.Data.Enum;
using Oem.Models.Service;
using Oem.Models.Service.UserDto;

namespace Oem.Services.IServices.User
{
    /// <summary>
    /// 用户服务接口
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        ServiceResult<ServiceStateEnum, UserDto> GetUser(long userId);
    }
}