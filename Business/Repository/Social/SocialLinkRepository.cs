﻿using System.Collections.Generic;
using System.Linq;
using Business.Dto.Social;
using Business.Services.Query;

namespace Business.Repository.Social
{
    public class SocialLinkRepository : BaseRepository, ISocialLinkRepository
    {
        public SocialLinkRepository(IDocumentQueryService documentQueryService) : base(documentQueryService)
        {
        }

        public IEnumerable<SocialLinkDto> GetSocialLinks()
        {
            return DocumentQueryService.GetDocuments<CMS.DocumentEngine.Types.MedioClinic.SocialLink>()
                .AddColumns("Title", "Url", "Icon")
                .OrderByAscending("NodeOrder")
                .Select(m => new SocialLinkDto()
                {
                    Url = m.Url,
                    Title = m.Title,
                    Icon = m.Fields.Icon
                });
        }
    }
}
