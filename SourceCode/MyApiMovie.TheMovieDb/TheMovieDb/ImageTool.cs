using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiMovie.TheMovieDb.TheMovieDb
{
    public static class ImageTool
    {
        public enum TypeImage { logo, poster, backdrop, profile, still }
        public enum SizeImage { w45, w92, w154, w185, w300, w342, w500, w780, w1280, h632, original}

        public static string GetFullPath(string imageName,TypeImage typeImage, SizeImage sizeImage)
        {
            string fullPath=TheMovieDbImage.BaseUrl;

            switch (typeImage)
            {
                case TypeImage.backdrop:{
                    switch (sizeImage)
                    {
                        case SizeImage.w300:
                            fullPath += TheMovieDbImage.w300;
                            break;
                        case SizeImage.w780:
                            fullPath += TheMovieDbImage.w780;
                            break;
                        case SizeImage.w1280:
                            fullPath += TheMovieDbImage.W1280;
                            break;
                        default:
                            fullPath += TheMovieDbImage.original;
                            break;
                    }
                    break;
                }
                case TypeImage.logo:{
                    switch (sizeImage)
                    {
                        case SizeImage.w45:
                            fullPath += TheMovieDbImage.w45;
                            break;
                        case SizeImage.w92:
                            fullPath += TheMovieDbImage.w92;
                            break;
                        case SizeImage.w154:
                            fullPath += TheMovieDbImage.w154;
                            break;
                        case SizeImage.w185:
                            fullPath += TheMovieDbImage.w185;
                            break;
                        case SizeImage.w300:
                            fullPath += TheMovieDbImage.w300;
                            break;
                        case SizeImage.w500:
                            fullPath += TheMovieDbImage.w500;
                            break;
                        default:
                            fullPath += TheMovieDbImage.original;
                            break;
                    }
                    break;}
                case TypeImage.poster:{
                    switch (sizeImage)
                    {
                        case SizeImage.w92:
                            fullPath += TheMovieDbImage.w92;
                            break;
                        case SizeImage.w154:
                            fullPath += TheMovieDbImage.w154;
                            break;
                        case SizeImage.w185:
                            fullPath += TheMovieDbImage.w185;
                            break;
                        case SizeImage.w342:
                            fullPath += TheMovieDbImage.w342;
                            break;
                        case SizeImage.w500:
                            fullPath += TheMovieDbImage.w500;
                            break;
                        case SizeImage.w780:
                            fullPath += TheMovieDbImage.w780;
                            break;
                        default:
                            fullPath += TheMovieDbImage.original;
                            break;
                    }
                    break;}
                case TypeImage.profile:{
                    switch (sizeImage)
                    {
                        case SizeImage.w45:
                            fullPath += TheMovieDbImage.w45;
                            break;
                        case SizeImage.w185:
                            fullPath += TheMovieDbImage.w185;
                            break;                        
                        case SizeImage.h632:
                            fullPath += TheMovieDbImage.h632;
                            break;
                        default:
                            fullPath += TheMovieDbImage.original;
                            break;
                    }
                    break;}
                case TypeImage.still:{
                    switch (sizeImage)
                    {
                        case SizeImage.w92:
                            fullPath += TheMovieDbImage.w92;
                            break;
                        case SizeImage.w185:
                            fullPath += TheMovieDbImage.w185;
                            break;
                        case SizeImage.w300:
                            fullPath += TheMovieDbImage.w300;
                            break;
                        default:
                            fullPath += TheMovieDbImage.original;
                            break;
                    }
                    break;}
                default:{
                    fullPath += TheMovieDbImage.original;
                    break;}
            }

            fullPath += String.Format("{0}", imageName);

            return fullPath;
            
        }
    }
}
