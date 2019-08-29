using System;

// HiQPdf namespace
using HiQPdf;

namespace HiQPdfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
     
            try
            {
                HtmlToPdf htmlToPdfConverter = new HtmlToPdf();

                htmlToPdfConverter.SerialNumber = "YCgJMTAE-BiwJAhIB-EhlWTlBA-UEBRQFBA-U1FOUVJO-WVlZWQ==";

                htmlToPdfConverter.HtmlLoadedTimeout = 120;

                htmlToPdfConverter.Document.PageSize = PdfPageSize.A4;

                htmlToPdfConverter.Document.PageOrientation = PdfPageOrientation.Portrait;

                htmlToPdfConverter.Document.PdfStandard = PdfStandard.Pdf;

                htmlToPdfConverter.Document.FontEmbedding = false;

                htmlToPdfConverter.TriggerMode = ConversionTriggerMode.Auto;

                htmlToPdfConverter.Document.Security.AllowPrinting = true;



                byte[] pdfBuffer = null;

                string htmlCode = $@"
                <!DOCTYPE html>
                <html>

                <head>
                    <title>Voucher</title>
                    <meta charset=""utf-8"" />
    
                    <link href='http://fonts.googleapis.com/css?family=Lato&subset=latin,latin-ext' rel='stylesheet' type='text/css'>
                <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
                    <style> 
                        {GetCss()}
                        {GetMediaForPrint()}
                    </style>

                </head>

                <body>

                    <div class=""container-fluid"">
                        <!-- Pricipal -->
                        <div class=""row"">
                            <!-- Middle Content -->
                            <div class=""col-12 pl-5 pr-5"">
                                <!-- Voucher icon -->
                                <div id=""payment-div"" class=""row pl-3 pr-3"">
                                    <div id=""voucher-logo"" class=""col-2 payment-detail"">
                                        <h3 class=""text-center"">VOUCHER
                                            <h3>
                                    </div>
                                    <!-- Contact -->
                                    <div class=""col-5 payment-detail default-background-color"">
                                        <ul class=""payment-detail-list"">
                                            <li>
                                                <p><b>Cliente:</b>
                                                    Postestur Agência de Viagens
                                                </p>
                                            </li>
                                            <li>
                                                <p><b>Contato:</b> Paula Valéria</p>
                                            </li>
                                            <li>
                                                <p><b>Proposta:</b> COT-108456-R1C</p>
                                            </li>
                                        </ul>
                                    </div>
                                    <!-- Cost -->
                                    <div class=""col-5 payment-detail default-background-color"">
                                        <ul class=""payment-detail-list"">
                                            <li>
                                                <p><b>Subtotal:</b> R$ 377,00</p>
                                            </li>
                                            <li>
                                                <p><b>Taxa:</b> 6%</p>
                                            </li>
                                            <li>
                                                <p><b>Total:</b> R$290,35</p>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                                <!-- Driver Detail Content -->
                                <div class=""row pl-3 pr-3 mt-4"">
                                    <div class=""col-3 p-0"">
                                        <div class=""pt-2 text-center service-detail-header default-background-color"">
                                            <h6>Motorista</h6>
                                        </div>
                                        <div class=""pt-2"">
                                            <div class=""col pt-2 "">
                                                <div id=""driver-image-div"">
                                                    <img id=""driver-image"" class=""img-fluid rounded"" src=""https://i.pinimg.com/originals/5d/a0/61/5da06183fd365467c0a140b5dc8fd7f3.jpg"" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""service-column driver-detail pb-4"">
                                            <div class=""pt-4 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Nome:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""driver-name"">Michelle Rodriguez</p>
                                                </div>
                                            </div>
                                            <div class=""pt-3 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Telefone:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""driver-phone"">(11) 97069-4762</p>
                                                </div>
                                            </div>
                                            <div class=""pt-3 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Documento:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""driver-document"">50605443-5</p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Service Detail Content -->
                                    <div class=""col-6 p-0"">
                                        <div class=""text-center pt-2 service-detail-header second-background"">
                                            <h6>Dados do Serviço</h6>
                                        </div>
                                        <div class=""service-column pb-4"">
                                            <div class=""pt-2 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Data / Hora:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""service-date"">07/08/2018 - 04:55</p>
                                                </div>
                                            </div>
                                            <div class=""pt-4 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Local de Apresentação:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""service-local"">Aeroporto Internacional de São Paulo - Rod. Hélio Smidt, s/nº - Cumbica, Guarulhos, SP - 07190-100 </p>
                                                </div>
                                            </div>
                                            <div class=""pt-4 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Local Destino:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""service-destination"">Mercure São Paulo Alamedas Hotel - Rua Padre João Manuel, 202 - Jardins, São Paulo, SP - 01411-000</p>
                                                </div>
                                            </div>
                                            <div class=""pt-4 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Observação:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""service-obs"">Motorista fará o receptivo com a placa</p>
                                                </div>
                                            </div>
                                            <div class=""pt-4 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Passageiro:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""service-customer"">George Papanastasiou - Voo: LH 506</p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <!-- Vehicle Detail Content -->
                                    <div class=""col-3 p-0"">
                                        <div class=""text-center pt-2 service-detail-header third-background"">
                                            <h6>Veículo</h6>
                                        </div>

                                        <div class=""service-column pb-4"">
                                            <div class=""pt-2 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Modelo:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""vehicle-model"">Sedan Executivo</p>
                                                </div>
                                            </div>
                                            <div class=""pt-4 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Idioma:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""vehicle-language"">Motorista Bilíngue</p>
                                                </div>
                                            </div>
                                            <div class=""pt-4 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Serviço:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""vehicle-service"">Translado(Ida ou Volta)</p>
                                                </div>
                                            </div>
                                            <div class=""pt-4 pl-2"">
                                                <div class=""row service-label"">
                                                    <p>Placa:</p>
                                                </div>
                                                <div class=""row text-justify pr-4"">
                                                    <p id=""vehicle-plate"">GDJ 0356</p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>

                        </div>

                        <!-- Term Content -->
                        <div class=""row pb-5"">
                            <div id=""term-head-div"" class=""col-12 pl-5 pr-5"">
                                <div id=""term-th"" class=""text-center"">
                                    <h4>Termos e Condições</h4>
                                </div>
                            </div>
                            <div class=""col-12 pl-5 pr-5 "">
                                <div id=""term-tr"" class=""text-justify default-background-color"">
                                    <p>is simply dummy text of the printing and typesetting industry. Lorem Ipsum has is simply dummy text of the printing and typesetting industry. Lorem Ipsum has</p>
                                </div>
                            </div>
                            <div class=""col-12 pl-5 pr-5 "">
                                <div id=""term-tr"" class=""text-justify default-background-color"">
                                    <p>is simply dummy text of the printing and typesetting industry. Lorem Ipsum has is simply dummy text of the printing and typesetting industry. Lorem Ipsum has</p>
                                </div>
                            </div>
                            <div class=""col-12 pl-5 pr-5 "">
                                <div id=""term-tr"" class=""text-justify default-background-color"">
                                    <p>is simply dummy text of the printing and typesetting industry. Lorem Ipsum has is simply dummy text of the printing and typesetting industry. Lorem Ipsum has</p>
                                </div>
                            </div>
                            <div class=""col-12 pl-5 pr-5 "">
                                <div id=""term-tr"" class=""text-justify default-background-color"">
                                    <p>is simply dummy text of the printing and typesetting industry. Lorem Ipsum has is simply dummy text of the printing and typesetting industry. Lorem Ipsum has</p>
                                </div>
                            </div>
                            <div class=""col-12 pl-5 pr-5 "">
                                <div id=""term-tr"" class=""text-justify default-background-color"">
                                    <p>is simply dummy text of the printing and typesetting industry. Lorem Ipsum has is simply dummy text of the printing and typesetting industry. Lorem Ipsum has</p>
                                </div>
                            </div>
                            <div class=""col-12 pl-5 pr-5 "">
                                <div id=""term-tr"" class=""text-justify default-background-color"">
                                    <p>is simply dummy text of the printing and typesetting industry. Lorem Ipsum has is simply dummy text of the printing and typesetting industry. Lorem Ipsum has</p>
                                </div>
                            </div>
                        </div>

                    </div>


                   <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
                <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
                <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
                </body>

                </html>";

                string baseUrl = string.Empty;

                pdfBuffer = htmlToPdfConverter.ConvertHtmlToMemory(htmlCode, baseUrl);
                System.IO.File.WriteAllBytes("HtmlToPdf.pdf", pdfBuffer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Conversion failed: {0}", ex.Message));
            }
        }

        public static string GetCss()
        {
            var css = @"

            * {
                margin: 0;
                padding: 0;
                border: 0;
            }

            body {
                height: 100%;
            }

            ul {
                list-style-type: none;
                padding-left: 20px;
            }

            p,
            h1,
            h2,
            h3,
            h4,
            h5,
            h6 {
                font-family: 'Lato';
                font-style: normal;
                margin-bottom: 0 !important;
            }

            .default-background-color {
                background-color: #F1F1F1;
            }

            .second-background {
                background-color: #E8E8E8;
            }

            .third-background {
                background-color: #D9D9D9;
            }

            table tr th {
                background-color: #FFC011;
            }


            /*==========================================================================================
                                                 Term
            ==========================================================================================*/

            #term-th {
                background-color: #FFC011;
                height: 90px;
                padding-top: 30px;
            }

            #term-head-div {
                padding-top: 65px;
                max-width: 100%;
            }

            #term-row-div {
                margin-left: 3rem !important;
                margin-right: 3rem !important;
            }

            #term-tr {
                padding-top: 10px;
                padding-bottom: 10px;
                padding-left: 15px;
                padding-right: 15px;
            }


            /*==========================================================================================
                                             Payment Datails
            ==========================================================================================*/

            .payment-detail {
                height: 90px !important;
            }

            #voucher-logo {
                background-color: #000;
                padding-left: 15px;
                padding-right: 15px;
            }

            #voucher-logo h3 {
                font-weight: bold;
                padding-top: 28px;
                color: #fff;
            }

            .payment-detail-list {
                padding-top: 10px;
            }

            #payment-div {
                padding-top: 25px;
            }


            /*==========================================================================================
                                             Service Datails
            ==========================================================================================*/

            #service-detail-header-div {
                padding-top: 25px;
            }

            .service-detail-header {
                height: 40px !important;
            }

            .service-label p {
                font-weight: bold;
            }

            .service-column {
                padding-left: 20px !important;
            }


            /*==========================================================================================
                                             Driver Datails
            ==========================================================================================*/

            #driver-image {
                width: 150px !important;
                height: 170px !important;
            }";


            return css;
        }
        public static string GetMediaForPrint()
        {
            var css = @"
            @media print {
                #voucher-logo {
                    background-color: #000 !important;
                    -webkit-print-color-adjust: exact;
                }
                #voucher-logo h3 {
                    font-size: 21px !important;
                    padding-top: 32px !important;
                }
                #term-body {
                    background-color: #F1F1F1 !important;
                    -webkit-print-color-adjust: exact;
                }
                .default-background-color {
                    background-color: #F1F1F1 !important;
                    -webkit-print-color-adjust: exact;
                }
                .second-background {
                    background-color: #E8E8E8 !important;
                    -webkit-print-color-adjust: exact;
                }
                .third-background {
                    background-color: #D9D9D9 !important;
                    -webkit-print-color-adjust: exact;
                }
                table tr th {
                    background-color: #FFC011 !important;
                    -webkit-print-color-adjust: exact;
                }
                table tr td {
                    background-color: #F1F1F1 !important;
                    -webkit-print-color-adjust: exact;
                }
                #term-th {
                    background-color: #FFC011 !important;
                    -webkit-print-color-adjust: exact;
                }
                ul {
                    padding-left: 30px;
                }
            }";

            return css;
        }
    }

}
