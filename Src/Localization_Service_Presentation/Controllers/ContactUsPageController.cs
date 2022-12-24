﻿

namespace Localization_Service_Presentation.Controllers;

public class ContactUsPageController : ApiControllerBase.ApiControllerBase
{

    [HttpGet("GetContactUsPageContact")]
    public async Task<ActionResult<GetContactUsPageContentDto>> GetContactUsPageContentAsync([FromQuery] GetContactUsPageResourceContentQuery dto, CancellationToken cancellationToken)
     => Ok(await Mediator.Send(dto, cancellationToken));



}
