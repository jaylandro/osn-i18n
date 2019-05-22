<template lang='pug'>
#app(dir='auto')
  #osni18n-presentation
    .eg-slideshow

      slide.intro-theme(enter='fadeIn' leave='fadeOut')
        h2 What the i18n??

      slide.local-eg-theme-forest-road(:steps=5, enter='fadeIn' leave='bounceOutLeft')
        h3 Goals...
        ul.goals
          eg-transition(enter='bounceInLeft' leave='bounceOutLeft')
            li(v-if='step >= 2') Translations 🎉
          eg-transition(enter='bounceInLeft' leave='bounceOutLeft')
            li(v-if='step >= 3') Country Data 🌍
          eg-transition(enter='bounceInLeft' leave='bounceOutLeft')
            li(v-if='step >= 4') Numeric Formatting 🔢
          eg-transition(enter='bounceInLeft' leave='bounceOutLeft')
            li(v-if='step >= 5') Automation throughout! 🤖
      
      slide.translations(enter='bounceInRight' leave='fadeOut', dir='auto')
        h5 Translations utilizing #[a(href='https://kazupon.github.io/vue-i18n/started.html#html' target="_blank") Vue-i18n]
        hello-world

      slide.local-eg-theme-city(enter='fadeIn' leave='fadeOut')
        eg-transition(enter='flipInX')
          eg-code-block(lang='javascript').
              const userLanguage = (window.navigator.userLanguage 
                || window.navigator.language).substring(0,2);
              
              const userLocale = languageMappings[userLanguage] 
                ? userLanguage 
                : 'en';

              const i18n = new VueI18n({
                locale: userLocale,
                messages: languageMappings,
              });

              // On select event calls:
              this.$i18n.locale = languageCode; 
      
      slide.local-eg-theme-spark.one(enter='fadeIn' leave='bounceOutLeft')
        eg-transition(enter='fadeInUp')
            img(src='https://assets.transifex.com/static/images/com/infographic-localization.png')
      
      slide.local-eg-theme-spark(enter='fadeIn' leave='bounceOutLeft')
        eg-transition(enter='fadeInUp')
            a(href='https://www.transifex.com/osn-i18n/osn-i18n/dashboard/' target='_blank')
              img(src='./assets/txlogo.png')
      
      slide.translations(enter='bounceInRight' leave='fadeOut', dir='auto')
        h5 Let's use our Country Data!
        country-select
      
      slide.diagram(enter='zoomInUp'  leave='zoomOutDown')
        h4 Our Flow
          img(src='./assets/i18nflow.png')
      
      slide.local-eg-theme-forest-road(:steps=5, enter='fadeIn' leave='bounceOutLeft')
        h3 Numeric Formatting (Dates, Currency, Time)
        ul.goals
          eg-transition(enter='bounceInLeft' leave='bounceOutLeft')
            li(v-if='step >= 2') 📅 Dates #[a(href='http://www.ecma-international.org/ecma-402/2.0/#sec-intl-datetimeformat-constructor') The Intl.DateTimeFormat Constructor] 
          eg-transition(enter='bounceInLeft' leave='bounceOutLeft')
            li(v-if='step >= 3') 💱 Currency #[a(href='https://kazupon.github.io/vue-i18n/guide/number.html') Vue-i18n Docs] 
          eg-transition(enter='bounceInLeft' leave='bounceOutLeft')
            li(v-if='step >= 4') 💱 Currency Conversion #[a(href='https://wt-cb52b229c28374763fb6f62476e67c6c-0.sandbox.auth0-extend.com/currency?amount=32') Webtask] 
          eg-transition(enter='bounceInLeft' leave='bounceOutLeft')
            li(v-if='step >= 5') 🕔 Time (Do you have 6 more #[a(href='https://date-fns.org/') hours]?)

      slide.local-eg-theme-space(enter='fadeIn'  leave='fadeOut')
          h3 The future is up to you
          h4 Jay Landro
          a(href='https://github.com/jaylandro') https://github.com/jaylandro <br />
          a(href='https://twitter.com/HippyHoarder') @HippyHoarder
</template>

<script>
import { Slideshow } from 'eagle.js'
import HelloWorld from './components/HelloWorld.vue'
import CountrySelect from './components/CountrySelect.vue'

export default {
  name: 'app',
  mixins: [Slideshow],
  components: {
    HelloWorld,
    CountrySelect,
  },
}
</script>

<style lang="scss">
@import url('https://fonts.googleapis.com/css?family=Noto+Sans&display=swap');
@import url('https://fonts.googleapis.com/css?family=Cabin+Sketch');

body {
  width: 100%;
  margin: 0 0;
  font-family: 'Noto Sans', sans-serif;
}
input, select {
  background: white;
  font-size: 0.5em;
  font-family: 'Noto Sans', sans-serif;
  border-width: 0 0 2px 0;
  padding: 6px;
  cursor: pointer;
}
#app {
  font-family: 'Noto Sans', sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  height: 100vh;
}

#osni18n-presentation {
  h3 {
    font-weight: normal;
    text-transform: uppercase;
  }
  .eg-slide-content {
    width: 28em;
    max-width: 85%;
    margin: 0 auto;
  }
  .goals {
    line-height: 1.8em;
  }
  .intro-theme {
    background-image: url('./assets/i18n.svg');
    background-repeat: repeat;
    background-size: 536px 280px;
    color: #000;
    h2 {
      background: rgba(255, 255, 255, .8);
      margin-top: 40%;
    }
  }
  .local-eg-theme-forest-road {
    background-image: url(https://i.imgur.com/hxTMFZW.jpg);
    background-position: center;
    background-size: cover;
    color: rgba(255, 255, 255, .9);
    font-family: 'Cabin Sketch';
    text-align: left;
    h3 {
      text-align: left;
      margin-top: 20%;
    }
    ul {
      list-style: none;
      padding-left: 0;
      font-size: 1.3em;
    }
    a {
      color: white;
    }
  }
  .translations .eg-slide-content {
    width: 50em;
    max-width: 100%;
  }
  .local-eg-theme-spark {
    @import url(https://fonts.googleapis.com/css?family=Special+Elite);
    a {
      display: block;
      margin-top: 12em;
    }
    &.one {
      overflow: auto;
    }
    background-image: url(https://i.imgur.com/FL9mwpd.jpg);
    background-position: center;
    background-size: cover;
  }
  .local-eg-theme-city {
    @import url(https://fonts.googleapis.com/css?family=Patrick+Hand+SC);
    @import './assets/ir-black';
    .eg-code-block {
      margin-top: 25%;
    }
    .code-box {
      border-radius: 5px;
      padding: 16px 22px;
    }
    background-image: url(https://i.imgur.com/kmmHith.jpg);
    background-position: center;
    background-size: cover;
  }
  .local-eg-theme-space {
    @import url(https://fonts.googleapis.com/css?family=Forum);
    color: rgba(255, 255, 255, 0.9);
    text-shadow: 0px 15px 5px rgba(0,0,0,0.1),
                 10px 20px 5px rgba(0,0,0,0.05),
                 -10px 20px 5px rgba(0,0,0,0.05);
    h3 {
      font-family: 'Forum';
      font-size: 1.5em;
      color: rgba(255, 255, 255, 0.9);
      letter-spacing: 1.5px;
      margin-top: 30%
    }
    a {
      color: rgba(255, 255, 255, 0.9);
    }
    background-image: url(https://i.imgur.com/yO2ivoD.jpg);
    background-position: center;
    background-size: cover;
  }
  .diagram h3 {
    text-transform: none;
  }
}
</style>
