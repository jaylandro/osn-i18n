import Vue from 'vue'
import VueI18n from 'vue-i18n'

Vue.use(VueI18n)

const languageMappings = {
  'en': require('./en.json'),
  'ja': require('./ja/en.json'),
  'fr': require('./fr/en.json'),
  'es': require('./es/en.json'),
  'ar': require('./ar/en.json'),
  'zh': require('./zh/en.json'),
};
const userLanguage = (window.navigator.userLanguage || window.navigator.language).substring(0,2);
const userLocale = languageMappings[userLanguage] ? userLanguage : 'en';

const i18n = new VueI18n({
  locale: userLocale,
  messages: languageMappings,
})

window.i18n = i18n;

export default i18n
