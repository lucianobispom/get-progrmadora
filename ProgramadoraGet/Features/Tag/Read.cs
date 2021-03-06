﻿using FluentValidation;
using Microsoft.EntityFrameworkCore;
using ProgramadoraGet.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramadoraGet.Features.Tag
{
    public class Read
    {
        public class Model
        {
            public Guid Id { get; set; }
            public Domain.TagType TagType { get; set; }
        }

        public class Services
        {
            private readonly Db db;

            public Services(Db db)
            {
                this.db = db;
            }

            public async Task<IList<Domain.Tag>> One(Model model)
            {
                if (model.Id == null) throw new NotFoundException();

                return await db.Tags
                     .Where(t => t.DeletedAt == null)
                     .Where(t => t.Id == model.Id)
                     .Select(tag => new Domain.Tag
                     {
                         Id = tag.Id,
                         Name = tag.Name,
                         CreatedAt = tag.CreatedAt

                     }).ToListAsync();
            }

            public async Task<IList<Domain.Tag>> ByTagType(Model model)
            {

                if (!Enum.IsDefined(typeof(Domain.TagType), model.TagType)) throw new ForbiddenException();

                return await db.Tags
                     .Where(t => t.DeletedAt == null)
                     .Where(t => t.TagType == model.TagType)
                     .Select(tag => new Domain.Tag
                     {
                         Id = tag.Id,
                         Name = tag.Name,
                         CreatedAt = tag.CreatedAt

                     }).ToListAsync();
            }



        }



    }
}
