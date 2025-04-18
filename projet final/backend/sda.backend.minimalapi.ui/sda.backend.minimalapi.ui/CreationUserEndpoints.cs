﻿using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.OpenApi;
using sda.backend.minimalapi.Core.Auths.Models;
using sda.backend.minimalapi.Core.Auths.IF;
namespace sda.backend.minimalapi.ui;

public static class CreationUserEndpoints
{
    public static void MapCreationUserEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/auth").WithTags(nameof(CreationUser));

        group.MapPost("/", async (CreationUser model,
                                    UserManager<AuthenticationUser> userManager
                                    ) =>
        {
            IResult result = TypedResults.BadRequest();

            //return TypedResults.Created($"/api/CreationUsers/{model.ID}", model);
            if (userManager.FindByEmailAsync(model.Email).Result == null)
            { 
                var resultCreationUser = await userManager.CreateAsync(new AuthenticationUser()
                {
                    UserName = model.UserName,
                    //Id = model.Email,
                    Email = model.Email
                }, model.Password);

                if (!resultCreationUser.Succeeded) { return result; }

            }

            result = TypedResults.Created("/api/auth", model);
            return result;
        })
        .WithName("CreateCreationUser")
        .WithOpenApi();

    }
}

