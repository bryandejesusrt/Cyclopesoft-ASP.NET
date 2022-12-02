using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Contracts
{
    public interface IClientService : IBaseService
    {
        ClientResponse SaveClient(ClientSaveDto clientSaveDto);
        ClientResponse UpdateClient(ClientUpdateDto clientSaveDto);
        ClientResponse RemoveClient(ClientRemoveDto clientSaveDto);

    }
}
