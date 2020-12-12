/* tslint:disable */
/* eslint-disable */
//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.9.2.0 (NJsonSchema v10.3.1.0 (Newtonsoft.Json v12.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------
// ReSharper disable InconsistentNaming



export class BaseContainer implements IBaseContainer {
    containerId!: number;
    userId?: string | undefined;
    layout?: Layout | undefined;
    componentType!: ComponentType;

    constructor(data?: IBaseContainer) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.containerId = _data["containerId"];
            this.userId = _data["userId"];
            this.layout = _data["layout"] ? Layout.fromJS(_data["layout"]) : <any>undefined;
            this.componentType = _data["componentType"];
        }
    }

    static fromJS(data: any): BaseContainer {
        data = typeof data === 'object' ? data : {};
        let result = new BaseContainer();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["containerId"] = this.containerId;
        data["userId"] = this.userId;
        data["layout"] = this.layout ? this.layout.toJSON() : <any>undefined;
        data["componentType"] = this.componentType;
        return data; 
    }
}

export interface IBaseContainer {
    containerId: number;
    userId?: string | undefined;
    layout?: Layout | undefined;
    componentType: ComponentType;
}

export class Layout implements ILayout {
    containerId!: number;
    i?: string | undefined;
    h!: number;
    w!: number;
    x!: number;
    y!: number;

    constructor(data?: ILayout) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.containerId = _data["containerId"];
            this.i = _data["i"];
            this.h = _data["h"];
            this.w = _data["w"];
            this.x = _data["x"];
            this.y = _data["y"];
        }
    }

    static fromJS(data: any): Layout {
        data = typeof data === 'object' ? data : {};
        let result = new Layout();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["containerId"] = this.containerId;
        data["i"] = this.i;
        data["h"] = this.h;
        data["w"] = this.w;
        data["x"] = this.x;
        data["y"] = this.y;
        return data; 
    }
}

export interface ILayout {
    containerId: number;
    i?: string | undefined;
    h: number;
    w: number;
    x: number;
    y: number;
}

export enum ComponentType {
    News = 0,
    Weather = 1,
}

export class NewsDto implements INewsDto {
    status?: string | undefined;
    totalResults!: number;
    articles?: Article[] | undefined;

    constructor(data?: INewsDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.status = _data["status"];
            this.totalResults = _data["totalResults"];
            if (Array.isArray(_data["articles"])) {
                this.articles = [] as any;
                for (let item of _data["articles"])
                    this.articles!.push(Article.fromJS(item));
            }
        }
    }

    static fromJS(data: any): NewsDto {
        data = typeof data === 'object' ? data : {};
        let result = new NewsDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["status"] = this.status;
        data["totalResults"] = this.totalResults;
        if (Array.isArray(this.articles)) {
            data["articles"] = [];
            for (let item of this.articles)
                data["articles"].push(item.toJSON());
        }
        return data; 
    }
}

export interface INewsDto {
    status?: string | undefined;
    totalResults: number;
    articles?: Article[] | undefined;
}

export class Article implements IArticle {
    source?: Source | undefined;
    author?: string | undefined;
    title?: string | undefined;
    description?: string | undefined;
    url?: string | undefined;
    urlToImage?: string | undefined;
    publishedAt!: Date;
    content?: string | undefined;

    constructor(data?: IArticle) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.source = _data["source"] ? Source.fromJS(_data["source"]) : <any>undefined;
            this.author = _data["author"];
            this.title = _data["title"];
            this.description = _data["description"];
            this.url = _data["url"];
            this.urlToImage = _data["urlToImage"];
            this.publishedAt = _data["publishedAt"] ? new Date(_data["publishedAt"].toString()) : <any>undefined;
            this.content = _data["content"];
        }
    }

    static fromJS(data: any): Article {
        data = typeof data === 'object' ? data : {};
        let result = new Article();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["source"] = this.source ? this.source.toJSON() : <any>undefined;
        data["author"] = this.author;
        data["title"] = this.title;
        data["description"] = this.description;
        data["url"] = this.url;
        data["urlToImage"] = this.urlToImage;
        data["publishedAt"] = this.publishedAt ? this.publishedAt.toISOString() : <any>undefined;
        data["content"] = this.content;
        return data; 
    }
}

export interface IArticle {
    source?: Source | undefined;
    author?: string | undefined;
    title?: string | undefined;
    description?: string | undefined;
    url?: string | undefined;
    urlToImage?: string | undefined;
    publishedAt: Date;
    content?: string | undefined;
}

export class Source implements ISource {
    id?: string | undefined;
    name?: string | undefined;

    constructor(data?: ISource) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.id = _data["id"];
            this.name = _data["name"];
        }
    }

    static fromJS(data: any): Source {
        data = typeof data === 'object' ? data : {};
        let result = new Source();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["name"] = this.name;
        return data; 
    }
}

export interface ISource {
    id?: string | undefined;
    name?: string | undefined;
}

export class WeatherAndForecast implements IWeatherAndForecast {
    currentWeather?: CurrentWeather | undefined;
    weather?: WeatherDto | undefined;

    constructor(data?: IWeatherAndForecast) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.currentWeather = _data["currentWeather"] ? CurrentWeather.fromJS(_data["currentWeather"]) : <any>undefined;
            this.weather = _data["weather"] ? WeatherDto.fromJS(_data["weather"]) : <any>undefined;
        }
    }

    static fromJS(data: any): WeatherAndForecast {
        data = typeof data === 'object' ? data : {};
        let result = new WeatherAndForecast();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["currentWeather"] = this.currentWeather ? this.currentWeather.toJSON() : <any>undefined;
        data["weather"] = this.weather ? this.weather.toJSON() : <any>undefined;
        return data; 
    }
}

export interface IWeatherAndForecast {
    currentWeather?: CurrentWeather | undefined;
    weather?: WeatherDto | undefined;
}

export class CurrentWeather implements ICurrentWeather {
    coord?: Coord | undefined;
    weather?: WeatherData[] | undefined;
    base?: string | undefined;
    main?: DayTempDetails | undefined;
    visibility!: number;
    wind?: Wind | undefined;
    clouds?: Clouds | undefined;
    dt!: number;
    sys?: DayDetails | undefined;
    timezone!: number;
    id!: number;
    name?: string | undefined;
    cod!: number;

    constructor(data?: ICurrentWeather) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.coord = _data["coord"] ? Coord.fromJS(_data["coord"]) : <any>undefined;
            if (Array.isArray(_data["weather"])) {
                this.weather = [] as any;
                for (let item of _data["weather"])
                    this.weather!.push(WeatherData.fromJS(item));
            }
            this.base = _data["base"];
            this.main = _data["main"] ? DayTempDetails.fromJS(_data["main"]) : <any>undefined;
            this.visibility = _data["visibility"];
            this.wind = _data["wind"] ? Wind.fromJS(_data["wind"]) : <any>undefined;
            this.clouds = _data["clouds"] ? Clouds.fromJS(_data["clouds"]) : <any>undefined;
            this.dt = _data["dt"];
            this.sys = _data["sys"] ? DayDetails.fromJS(_data["sys"]) : <any>undefined;
            this.timezone = _data["timezone"];
            this.id = _data["id"];
            this.name = _data["name"];
            this.cod = _data["cod"];
        }
    }

    static fromJS(data: any): CurrentWeather {
        data = typeof data === 'object' ? data : {};
        let result = new CurrentWeather();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["coord"] = this.coord ? this.coord.toJSON() : <any>undefined;
        if (Array.isArray(this.weather)) {
            data["weather"] = [];
            for (let item of this.weather)
                data["weather"].push(item.toJSON());
        }
        data["base"] = this.base;
        data["main"] = this.main ? this.main.toJSON() : <any>undefined;
        data["visibility"] = this.visibility;
        data["wind"] = this.wind ? this.wind.toJSON() : <any>undefined;
        data["clouds"] = this.clouds ? this.clouds.toJSON() : <any>undefined;
        data["dt"] = this.dt;
        data["sys"] = this.sys ? this.sys.toJSON() : <any>undefined;
        data["timezone"] = this.timezone;
        data["id"] = this.id;
        data["name"] = this.name;
        data["cod"] = this.cod;
        return data; 
    }
}

export interface ICurrentWeather {
    coord?: Coord | undefined;
    weather?: WeatherData[] | undefined;
    base?: string | undefined;
    main?: DayTempDetails | undefined;
    visibility: number;
    wind?: Wind | undefined;
    clouds?: Clouds | undefined;
    dt: number;
    sys?: DayDetails | undefined;
    timezone: number;
    id: number;
    name?: string | undefined;
    cod: number;
}

export class Coord implements ICoord {
    lon!: number;
    lat!: number;

    constructor(data?: ICoord) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.lon = _data["lon"];
            this.lat = _data["lat"];
        }
    }

    static fromJS(data: any): Coord {
        data = typeof data === 'object' ? data : {};
        let result = new Coord();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["lon"] = this.lon;
        data["lat"] = this.lat;
        return data; 
    }
}

export interface ICoord {
    lon: number;
    lat: number;
}

export class WeatherData implements IWeatherData {
    id!: number;
    main?: string | undefined;
    description?: string | undefined;
    icon?: string | undefined;

    constructor(data?: IWeatherData) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.id = _data["id"];
            this.main = _data["main"];
            this.description = _data["description"];
            this.icon = _data["icon"];
        }
    }

    static fromJS(data: any): WeatherData {
        data = typeof data === 'object' ? data : {};
        let result = new WeatherData();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["main"] = this.main;
        data["description"] = this.description;
        data["icon"] = this.icon;
        return data; 
    }
}

export interface IWeatherData {
    id: number;
    main?: string | undefined;
    description?: string | undefined;
    icon?: string | undefined;
}

export class DayTempDetails implements IDayTempDetails {
    temp!: number;
    feelsLike!: number;
    temp_min!: number;
    temp_max!: number;
    pressure!: number;
    humidity!: number;

    constructor(data?: IDayTempDetails) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.temp = _data["temp"];
            this.feelsLike = _data["feelsLike"];
            this.temp_min = _data["temp_min"];
            this.temp_max = _data["temp_max"];
            this.pressure = _data["pressure"];
            this.humidity = _data["humidity"];
        }
    }

    static fromJS(data: any): DayTempDetails {
        data = typeof data === 'object' ? data : {};
        let result = new DayTempDetails();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["temp"] = this.temp;
        data["feelsLike"] = this.feelsLike;
        data["temp_min"] = this.temp_min;
        data["temp_max"] = this.temp_max;
        data["pressure"] = this.pressure;
        data["humidity"] = this.humidity;
        return data; 
    }
}

export interface IDayTempDetails {
    temp: number;
    feelsLike: number;
    temp_min: number;
    temp_max: number;
    pressure: number;
    humidity: number;
}

export class Wind implements IWind {
    speed!: number;
    deg!: number;
    gust!: number;

    constructor(data?: IWind) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.speed = _data["speed"];
            this.deg = _data["deg"];
            this.gust = _data["gust"];
        }
    }

    static fromJS(data: any): Wind {
        data = typeof data === 'object' ? data : {};
        let result = new Wind();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["speed"] = this.speed;
        data["deg"] = this.deg;
        data["gust"] = this.gust;
        return data; 
    }
}

export interface IWind {
    speed: number;
    deg: number;
    gust: number;
}

export class Clouds implements IClouds {
    all!: number;

    constructor(data?: IClouds) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.all = _data["all"];
        }
    }

    static fromJS(data: any): Clouds {
        data = typeof data === 'object' ? data : {};
        let result = new Clouds();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["all"] = this.all;
        return data; 
    }
}

export interface IClouds {
    all: number;
}

export class DayDetails implements IDayDetails {
    type!: number;
    id!: number;
    country?: string | undefined;
    sunrise!: number;
    sunriseDate!: Date;
    sunset!: number;
    sunsetDate!: Date;

    constructor(data?: IDayDetails) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.type = _data["type"];
            this.id = _data["id"];
            this.country = _data["country"];
            this.sunrise = _data["sunrise"];
            this.sunriseDate = _data["sunriseDate"] ? new Date(_data["sunriseDate"].toString()) : <any>undefined;
            this.sunset = _data["sunset"];
            this.sunsetDate = _data["sunsetDate"] ? new Date(_data["sunsetDate"].toString()) : <any>undefined;
        }
    }

    static fromJS(data: any): DayDetails {
        data = typeof data === 'object' ? data : {};
        let result = new DayDetails();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type;
        data["id"] = this.id;
        data["country"] = this.country;
        data["sunrise"] = this.sunrise;
        data["sunriseDate"] = this.sunriseDate ? this.sunriseDate.toISOString() : <any>undefined;
        data["sunset"] = this.sunset;
        data["sunsetDate"] = this.sunsetDate ? this.sunsetDate.toISOString() : <any>undefined;
        return data; 
    }
}

export interface IDayDetails {
    type: number;
    id: number;
    country?: string | undefined;
    sunrise: number;
    sunriseDate: Date;
    sunset: number;
    sunsetDate: Date;
}

export class WeatherDto implements IWeatherDto {
    cod!: number;
    message!: number;
    cnt!: number;
    list?: Data[] | undefined;
    city?: CityDetails | undefined;

    constructor(data?: IWeatherDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.cod = _data["cod"];
            this.message = _data["message"];
            this.cnt = _data["cnt"];
            if (Array.isArray(_data["list"])) {
                this.list = [] as any;
                for (let item of _data["list"])
                    this.list!.push(Data.fromJS(item));
            }
            this.city = _data["city"] ? CityDetails.fromJS(_data["city"]) : <any>undefined;
        }
    }

    static fromJS(data: any): WeatherDto {
        data = typeof data === 'object' ? data : {};
        let result = new WeatherDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["cod"] = this.cod;
        data["message"] = this.message;
        data["cnt"] = this.cnt;
        if (Array.isArray(this.list)) {
            data["list"] = [];
            for (let item of this.list)
                data["list"].push(item.toJSON());
        }
        data["city"] = this.city ? this.city.toJSON() : <any>undefined;
        return data; 
    }
}

export interface IWeatherDto {
    cod: number;
    message: number;
    cnt: number;
    list?: Data[] | undefined;
    city?: CityDetails | undefined;
}

export class Data implements IData {
    dt!: number;
    main?: MainClass | undefined;
    weather?: WeatherElement[] | undefined;
    clouds?: Clouds | undefined;
    wind?: Wind | undefined;
    visibility!: number;
    pop!: number;
    sys?: Sys | undefined;
    dt_txt!: Date;
    rain?: Rain | undefined;

    constructor(data?: IData) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.dt = _data["dt"];
            this.main = _data["main"] ? MainClass.fromJS(_data["main"]) : <any>undefined;
            if (Array.isArray(_data["weather"])) {
                this.weather = [] as any;
                for (let item of _data["weather"])
                    this.weather!.push(WeatherElement.fromJS(item));
            }
            this.clouds = _data["clouds"] ? Clouds.fromJS(_data["clouds"]) : <any>undefined;
            this.wind = _data["wind"] ? Wind.fromJS(_data["wind"]) : <any>undefined;
            this.visibility = _data["visibility"];
            this.pop = _data["pop"];
            this.sys = _data["sys"] ? Sys.fromJS(_data["sys"]) : <any>undefined;
            this.dt_txt = _data["dt_txt"] ? new Date(_data["dt_txt"].toString()) : <any>undefined;
            this.rain = _data["rain"] ? Rain.fromJS(_data["rain"]) : <any>undefined;
        }
    }

    static fromJS(data: any): Data {
        data = typeof data === 'object' ? data : {};
        let result = new Data();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["dt"] = this.dt;
        data["main"] = this.main ? this.main.toJSON() : <any>undefined;
        if (Array.isArray(this.weather)) {
            data["weather"] = [];
            for (let item of this.weather)
                data["weather"].push(item.toJSON());
        }
        data["clouds"] = this.clouds ? this.clouds.toJSON() : <any>undefined;
        data["wind"] = this.wind ? this.wind.toJSON() : <any>undefined;
        data["visibility"] = this.visibility;
        data["pop"] = this.pop;
        data["sys"] = this.sys ? this.sys.toJSON() : <any>undefined;
        data["dt_txt"] = this.dt_txt ? this.dt_txt.toISOString() : <any>undefined;
        data["rain"] = this.rain ? this.rain.toJSON() : <any>undefined;
        return data; 
    }
}

export interface IData {
    dt: number;
    main?: MainClass | undefined;
    weather?: WeatherElement[] | undefined;
    clouds?: Clouds | undefined;
    wind?: Wind | undefined;
    visibility: number;
    pop: number;
    sys?: Sys | undefined;
    dt_txt: Date;
    rain?: Rain | undefined;
}

export class MainClass implements IMainClass {
    temp!: number;
    feelsLike!: number;
    temp_min!: number;
    temp_max!: number;
    pressure!: number;
    seaLevel!: number;
    grndLevel!: number;
    humidity!: number;
    tempKf!: number;

    constructor(data?: IMainClass) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.temp = _data["temp"];
            this.feelsLike = _data["feelsLike"];
            this.temp_min = _data["temp_min"];
            this.temp_max = _data["temp_max"];
            this.pressure = _data["pressure"];
            this.seaLevel = _data["seaLevel"];
            this.grndLevel = _data["grndLevel"];
            this.humidity = _data["humidity"];
            this.tempKf = _data["tempKf"];
        }
    }

    static fromJS(data: any): MainClass {
        data = typeof data === 'object' ? data : {};
        let result = new MainClass();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["temp"] = this.temp;
        data["feelsLike"] = this.feelsLike;
        data["temp_min"] = this.temp_min;
        data["temp_max"] = this.temp_max;
        data["pressure"] = this.pressure;
        data["seaLevel"] = this.seaLevel;
        data["grndLevel"] = this.grndLevel;
        data["humidity"] = this.humidity;
        data["tempKf"] = this.tempKf;
        return data; 
    }
}

export interface IMainClass {
    temp: number;
    feelsLike: number;
    temp_min: number;
    temp_max: number;
    pressure: number;
    seaLevel: number;
    grndLevel: number;
    humidity: number;
    tempKf: number;
}

export class WeatherElement implements IWeatherElement {
    id!: number;
    main?: string | undefined;
    description?: string | undefined;
    icon?: string | undefined;

    constructor(data?: IWeatherElement) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.id = _data["id"];
            this.main = _data["main"];
            this.description = _data["description"];
            this.icon = _data["icon"];
        }
    }

    static fromJS(data: any): WeatherElement {
        data = typeof data === 'object' ? data : {};
        let result = new WeatherElement();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["main"] = this.main;
        data["description"] = this.description;
        data["icon"] = this.icon;
        return data; 
    }
}

export interface IWeatherElement {
    id: number;
    main?: string | undefined;
    description?: string | undefined;
    icon?: string | undefined;
}

export class Sys implements ISys {
    pod?: string | undefined;

    constructor(data?: ISys) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.pod = _data["pod"];
        }
    }

    static fromJS(data: any): Sys {
        data = typeof data === 'object' ? data : {};
        let result = new Sys();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["pod"] = this.pod;
        return data; 
    }
}

export interface ISys {
    pod?: string | undefined;
}

export class Rain implements IRain {
    _3h!: number;

    constructor(data?: IRain) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this._3h = _data["3h"];
        }
    }

    static fromJS(data: any): Rain {
        data = typeof data === 'object' ? data : {};
        let result = new Rain();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["3h"] = this._3h;
        return data; 
    }
}

export interface IRain {
    _3h: number;
}

export class CityDetails implements ICityDetails {
    id!: number;
    name?: string | undefined;
    coord?: Coord2 | undefined;
    country?: string | undefined;
    population!: number;
    timezone!: number;
    sunrise!: number;
    sunriseDate!: Date;
    sunset!: number;
    sunsetDate!: Date;

    constructor(data?: ICityDetails) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.id = _data["id"];
            this.name = _data["name"];
            this.coord = _data["coord"] ? Coord2.fromJS(_data["coord"]) : <any>undefined;
            this.country = _data["country"];
            this.population = _data["population"];
            this.timezone = _data["timezone"];
            this.sunrise = _data["sunrise"];
            this.sunriseDate = _data["sunriseDate"] ? new Date(_data["sunriseDate"].toString()) : <any>undefined;
            this.sunset = _data["sunset"];
            this.sunsetDate = _data["sunsetDate"] ? new Date(_data["sunsetDate"].toString()) : <any>undefined;
        }
    }

    static fromJS(data: any): CityDetails {
        data = typeof data === 'object' ? data : {};
        let result = new CityDetails();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["name"] = this.name;
        data["coord"] = this.coord ? this.coord.toJSON() : <any>undefined;
        data["country"] = this.country;
        data["population"] = this.population;
        data["timezone"] = this.timezone;
        data["sunrise"] = this.sunrise;
        data["sunriseDate"] = this.sunriseDate ? this.sunriseDate.toISOString() : <any>undefined;
        data["sunset"] = this.sunset;
        data["sunsetDate"] = this.sunsetDate ? this.sunsetDate.toISOString() : <any>undefined;
        return data; 
    }
}

export interface ICityDetails {
    id: number;
    name?: string | undefined;
    coord?: Coord2 | undefined;
    country?: string | undefined;
    population: number;
    timezone: number;
    sunrise: number;
    sunriseDate: Date;
    sunset: number;
    sunsetDate: Date;
}

export class Coord2 implements ICoord2 {
    lat!: number;
    lon!: number;

    constructor(data?: ICoord2) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.lat = _data["lat"];
            this.lon = _data["lon"];
        }
    }

    static fromJS(data: any): Coord2 {
        data = typeof data === 'object' ? data : {};
        let result = new Coord2();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["lat"] = this.lat;
        data["lon"] = this.lon;
        return data; 
    }
}

export interface ICoord2 {
    lat: number;
    lon: number;
}

export class WeatherForecast implements IWeatherForecast {
    date!: Date;
    temperatureC!: number;
    temperatureF!: number;
    summary?: string | undefined;

    constructor(data?: IWeatherForecast) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.date = _data["date"] ? new Date(_data["date"].toString()) : <any>undefined;
            this.temperatureC = _data["temperatureC"];
            this.temperatureF = _data["temperatureF"];
            this.summary = _data["summary"];
        }
    }

    static fromJS(data: any): WeatherForecast {
        data = typeof data === 'object' ? data : {};
        let result = new WeatherForecast();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["date"] = this.date ? this.date.toISOString() : <any>undefined;
        data["temperatureC"] = this.temperatureC;
        data["temperatureF"] = this.temperatureF;
        data["summary"] = this.summary;
        return data; 
    }
}

export interface IWeatherForecast {
    date: Date;
    temperatureC: number;
    temperatureF: number;
    summary?: string | undefined;
}

export interface FileResponse {
    data: Blob;
    status: number;
    fileName?: string;
    headers?: { [name: string]: any };
}