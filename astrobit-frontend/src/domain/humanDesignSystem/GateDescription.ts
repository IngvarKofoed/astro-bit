

export function getGateDescription(gateNumber: number): GateDescription {
    // return gateDescriptions[0];
    var description = gateDescriptions.find(x => x.number == gateNumber);
    if (description === undefined) throw new Error();
    return description; 
}


export class GateDescription {
    constructor (
        public readonly number: number,
        public readonly name: string,
        public readonly paragraphs: string[],
        public readonly affirmations: string[],
        public readonly assignments: string[]) {
        }
}


export const gateDescriptions = [
    new GateDescription(
        1,
        'Self-Expression',
        [
            'Gate 1 is the most yang of the hexagrams (yang-yang). This is a powerful energy that pushes on a person’s spirit if they don’t fulfill their need to express themselves creatively. This energy will wake you up at night with the thought that there is something you are supposed to be doing with your life, and if you don’t know what that is, you can become very anxious.',
            'Gate 1 by itself is always seeking more energy to get this expression to the Throat. It may have to get it from others in collaboration, but it will not feel comfortable or fulfilled unless it finds a way to express itself. People with this energy want to do more than volunteer for a blood drive; they want to change the world. And they have the motivation to do it, provided they use this energy correctly.',
            'There is a tremendous amount of knowing in this channel. There is a knowing about the right contribution at the right time. Someone with Gate 1 may have to wait for recognition and the right energy to move the contribution of their soul out into the world. Waiting is hard, but it is crucial to have the correct impact.'
        ],
        [
            'Every day is a new creation.',
            'My greatest contribution to the planet is to be the fullest expression of myself as myself.',
            'The fulfillment of my divine potential is important for the evolution of humanity.',
            'I trust the process and release any fears that I may have about “failing my life mission.”',
            'I am on task and in the right place, making the right contribution.'
        ],
        [
            'Are there times when you hold yourself back from fully expressing yourself? What would it take for you to step into your fullest expression?',
            'What does the word “legacy” mean to you? Are you leaving an authentic legacy? Are there limiting beliefs and experiences preventing you from expressing your authenticity? What do you need to do to release them?'
        ]
    ),

    new GateDescription(
        2,
        'Keeper of Keys',
        [
            'Gate 2 is the energy for managing wealth. It is the most yin of the hexagrams (yin-yin).',
            'Gate 2 is not necessarily the energy for making money, but it likes money and the comfort of knowing that the financial foundation is secure and supported consistently. Gate 2 takes in the resources created by Gate 14 and allocates them in order to facilitate the expression of power.',
            'Of course, this gate can have a youthful expression that can lead it into reckless spending without the awareness or willingness of what is necessary to generate wealth. The metaphor of a teenage girl at the mall with her daddy’s credit card fits well here. But ultimately, the highest expression of this energy is about having and managing resources well, so that you have what you need to make a transformative expression and contribution in the world. Gate 2 manages resources so that wealth is available to create influence and to get things done in a transformative way.'
        ],
        [
            'I am wise about resources and understand what is necessary to build a strong foundation of support for my destiny and my contribution to the world.'
        ],
        [
            'What steps do you need to take to surrender to your destiny?',
             'What resources are necessary?',
            'What resources do you have already? What do you need to do to create a solid foundation of support for the fulfillment of your dreams?'
        ]
    ),

    new GateDescription(
        3,
        'Ordering',
        [
            'Gate 3 is about mutation and transformation. On a genetic level, Gate 3 brings new genetic material that pushes up against old genetic material to see if it can be integrated. On a work level, it seeks to mutate the work experience and response. Gate 3 responds to work that brings change that, without limitation, can often be maladaptive or just plain strange. The purpose of Gate 3 is to respond to work that is vital to transforming or creating change in the world. Gate 3, like all mutation, has difficulty in the beginning. It has to have this in order to “prove” that the energy is worth integrating. Without the struggle, society is at risk for reckless and capricious change.',
            'People who have this energy defined in their charts can sometimes feel that things are harder for them in the beginning. Perseverance will ultimately show them whether their difficulty was worthwhile or not.'
        ],
        [
            'I accept and embrace limitation and love what is.',
            'I trust that what I am experiencing in this moment will perfectly support me in creating what I intend.'
        ],
        [
            'Are there areas of your life where you feel as though you are getting some resistance or “butting your head against a wall”? What do you need to accept to release these resistances?',
            'Do you want to do something but sense that perhaps the timing isn’t right? Do you need to keep pushing, or is it time to let go and trust in divine timing?'
        ]
    ),

    new GateDescription(
        4,
        'Answers',
        [
            'Gate 4 is the gate of the answer. The answer to what, you may wonder. It doesn’t matter. It’s just the answer. Answers come from Gate 4 without a lot of regard for validity. They are merely possibilities that need to be proven over time.',
            'People with this energy, especially with an open head, will be under pressure to come up with answers. Answers can sometimes just “plop” out of this person’s mouth. Remember that answering is simply an energy; just because someone has an answer doesn’t make it the right one.'
        ],
        [
            'The culmination of my thoughts and experiences grant me knowledge about how I need to proceed confidently and faithfully into the future.',
            'I patiently wait to see if my answers are correct.'
        ],
        [
            'What new awarenesses, knowledge, and insights do you have as a result of your thoughts, experiences, and meditations?',
            'What are the next steps you need to take in your creative processes?'
        ]
    ),

    new GateDescription(
        5,
        'Patterns',
        [
            'Gate 5 is deeply rhythmic. When you have this energy, it is vital that you maintain a routine in order to feel effective and good. You may find that if your routine gets interrupted, you have a hard time getting your day going.',
            'If you are a Generator with this gate, you will respond to opportunities for work and sex that are rhythmic. Gate 5 likes routine, even intimacy and work that has a pattern, consistency, and rhythm.'
        ],
        [
            'My routines and habits are necessary to help me direct my life force.',
            'I give myself time and room for my daily rhythm, and I honor myself enough to honor my special rituals. They keep me grounded and connected to Source.'
        ],
        [
            'Do you have a daily rhythm? What do you need to do each day to honor yourself, Source, and the world around you?',
            'Are you getting enough time outside? What do you need to do to reconnect with the natural world?'
        ]
    ),

    new GateDescription(
        6,
        'Friction',
        [
            'Gate 6 connects the Sacral to the Emotional Solar Plexus. It is a penetrating energy, meaning that it can break into people’s auras. It is emotional and energetic, not seductive.',
            'Sexually, this is the energy that “locks on to” another person’s aura and, if used properly, can be a gateway to true intimacy. In Human Design, true intimacy comes not only from sex but also from reproduction.',
            'The sexuality of the sixth gate is emotional. It needs clarity over time. “Evaluate and then penetrate” could be the mantra for this gate. Wait to make sure it is the right thing.',
            'Intimacy that is waited for has the possibility of being nurturing, even though nurturing isn’t inherent in this energy. When you don’t wait, the relationship will not feel nurturing and ultimately will come apart. The result of the collapse of this incorrect intimacy can be war or conflict, a lot of emotions in reaction to a bad choice.',
            'The energy of war and conflict in this gate can also be defensive. Conflict that is being instigated as a result of time and clarity (waiting the emotional wave) can be in defense of loved ones. The Tribal Circuit (see chapter 6) requires that you energetically give up your life for the greater good of the whole. You fight for love and resources. Gate 6, with clarity, will be the first one to throw a spear to protect the tribe.',
            'Of course, clarity is crucial here. Without clarity, war can be destructive and ultimately kill the tribe.'
        ],
        [
            'I surrender myself to life.',
            'I surrender myself to my destiny and all that it means to be myself and me.'            
        ],
        [
            'Are your desires in alignment with the truth of who you are? Are you living authentically, boldly, as yourself? Where might you need to make changes?'
        ]
    ),

    new GateDescription(
        7,
        'Self in Interaction',
        [
            'Gate 7 is here to serve a leadership that is bigger than itself. Because it is designed to support the leadership, the low expression of Gate 7 often struggles to try to take leadership, but usually without much success.',
            'These are energies that have to be recognized and are, by nature, truly democratic in their highest expression. You cannot force leadership with this energy. It won’t last.',
            'People with either Gate 7 or Gate 31 are recognized as natural leaders. It is quite common for them to be put into leadership roles by a group. That is where they are supposed to be.'
        ],
        [
            'I take leadership in my life and know that I will be called on to share my influence with the world.',
            'I am empowered, and I trust the geometry of the Universe to take me to exactly where I need to go to impress my authentic expression on the world.'
        ],
        [
            'Where do you need to take action and leadership in your life? What do you need to do to lead your dream?',
            'What kind of influence and recognition would you like to be experiencing in your life? What has kept you from recognition in the past? Is there anything you need to change to increase your light?'
        ]
    ),

    new GateDescription(
        8,
        'Contribution',
        [
            'Gate 8 lacks some of the pressure of Gate 1, but it still feels the need to make a contribution. This is the final expression of individuality to the Throat Center that comes from the Sacral.',
            'Gate 8 wants to get things done, make a difference, create change, but it can’t unless it hooks with the correct energies and it gets recognition. The key here is correct timing and the right energies. Sometimes, that means waiting, which can be especially hard when there is a world to change.',
            'In its fulfilled expression, Gate 8 is the creative role model. It waits for correct timing and then shares by “walking its talk.” Gate 8 operating correctly is inspiring and creates change by leading by example.'
        ],
        [
            'The greatest contribution I can make is to share my light, my love, my self with the world. I commit to making my contribution by expressing my authenticity to its fullest extent.',
            'I never hold back. I radiate. I am a crucial part of the light of the wholeness of mankind.'
        ],
        [
            'If you could live an uncompromising life, what would it look like?',
            'What do you need to do to bring this life forth? Is there anything stopping you?'
        ]
    ),

    new GateDescription(
        9,
        'Focus',
        [
            'Gate 9 is the energy for focus. Whenever you see this in a chart, you know there is always the capacity for obsessive behavior and thinking. To a certain degree, Gate 9 will amp up all the energies of a chart, especially if the energy makes it to the Throat Center and isn’t split off.',
            'Gate 9 has the ability to focus, but not necessarily for long periods of time. This gate is a crucial player in ADD-like behavior, where you are focused but also constantly moving.',
            'If you have this energy, you may often seem obsessive to others, as if you can’t let an idea go. With Gate 9, it’s true. You can’t let it go. You can think about it no matter what you’re doing. You just might not be able to stop and concentrate on it unless you find someone with Gate 52. Both gates are crucial for learning and taking logic into collective behavioral patterns.'
        ],
        [
            'I am always concentrating on my intentions, even if I’m busy doing other things.',
            'I follow my strategy and take actions that are in alignment with my concentration.',
            'I know that my inner concentration will manifest in my outer world.'
        ],
        [
            'Take a sheet of paper and draw a line down the middle. Title the left column “Me.” Title the right column “The Universe.”',
            'In the left column make a list of all the things you need to do to make your dream come true. These are the practical things you need to take care of, such as writing a book, test driving a car, building a website, taking a class, etc.',
            'In the right column make a list of all the things the Universe can do. These are the things that may feel beyond your control at the moment, such as attracting the perfect clients, friends, or lover; providing the perfect information and support; etc.'
        ]
    ),

    new GateDescription(
        10,
        'Love of Self',
        [
            'Gate 10 is one of the most significant gates. It is rooted in the Identity Center and associated with empowerment. The energy of empowerment in this gate is lived out by example: someone with this gate empowers others to live out their magnificence by demonstrating their own magnificence.',
            'Gate 10 can be a difficult energy. In its highest expression, this is a gate of taking personal responsibility and acting in an empowered way. In its low expression, it is the energy for blaming others and taking a victim stance.',
            'As this energy can be amplified by those who do not have it, the theme of blame can be prevalent in the life of the person carrying the energy of Gate 10. People with Gate 10 get blamed or blame others when they live out of their conditioning.',
            'It is vital to see where Gate 10 connects: With Gate 57, we have perfected form and intuitive survival. With Gate 34, we have the Centering Circuit, which is again associated with the perfected form of survival and direction. With Gate 20, Gate 10 has the capacity to communicate empowerment.'
        ],
        [
            'I honor that miracle that I am. I am a unique, divine creation, and I know there is no one like me in this world.',
            'I make choices and take actions that are honoring of my divine magnificence, and I surround myself with people who support me, nurture me, inspire me, and lift me up.,',
            'I am powerful and in charge of my life direction.',
            'I make choices that allow me to fulfill my divine potential, and in being the fullest expression of myself, I create the space for others to do the same.',
            'I know that my self-love helps me align with my life path.'
        ],
        [
            'What old energies and “victim stories” do you need to release?',
            'What does being powerful mean to you? What can you do to be more empowered?',
            'Make a list of all the things you love about yourself. Write yourself a beautiful love letter and read it aloud in the mirror.',
            'What choices and directions could you take that would be in alignment with your self-love?'
        ]
    ),

    new GateDescription(
        11,
        'Ideas',
        [
            'If you imagine that creativity is a stream, most of us go down to it with a cup and drink from it. People with Gate 11 go down to the Stream of Creativity with twenty washbasins and stand on the banks wondering what to do with all their ideas.',
            'Gate 11 is filled with more ideas than one will ever be able to bring into form in a lifetime. The frustration of Gate 11 is the desire to implement one’s ideas. People with Gate 11 will often complain that others “stole” their ideas or that they got “scooped.”',
            'People with Gate 11 will make peace with their ideas if they realize that all of their ideas are not for them but to share with others … when asked. The challenge of this gate is to sit and wait for the right person to ask for their ideas.',
            'Gate 11 is also the gate of the seeker, not the finder. When people with Gate 11 make peace with always being on a quest and never having a certain answer, they can enjoy the journey. Remember, Gate 11 is the gate of ideas. You don’t have to manifest all of them—or any of them. If an idea is correct for you, it will show up in your life according to your personal Human Design strategy.'
        ],
        [
            'I honor my inner creative process.',
            'I am grateful for every lesson and adventure I have in life, and I know that each story of my life experience adds beautiful, rich threads to the tapestry of my life story and the story of humanity.',
            'I relax and enjoy the quest for truth in my life, knowing that the more I learn, the more I grow, and the learning and growing never stop.',
            'I allow myself to savor every moment and serve as the creative vessel I am. I relax, breathe, trust, and let the ideas flow!'
        ],
        [
            'Evaluate your achievements and accomplishments of the last few weeks. What have you learned? How can you improve upon what you’ve already done?',
            'Keep a running list of ideas this week. You never know when you might find the right person to share them with or when you may hit upon the million-dollar idea for your life!'
        ]
    ),

    new GateDescription(
        12,
        'Caution',
        [
            'Gate 12 is cautious because it needs to know whether it is being honored or not. The root expression of this caution is shyness if the mood is not right and boldness if it is. Gate 12 is also a powerful energy that plugs into Source, and people with this energy, especially if it is defined on an open Throat Center, have a tendency to channel or prophesize.',
            'There is a certain frustration and anger here if Gate 12 shares and the timing is not right. Sometimes Gate 12 can retreat into an “I told you so” kind of energy when their insights are proven correct in hindsight.',
            'The irony of manifested energy is very strong in this gate. There is an impetus to speak or act, but if someone has been conditioned to act no matter what, they may have the experience of speaking boldly and creating anger around them. This can be a real inner struggle for people with this energy, often creating a “standstill” in their lives. People with this energy can become paralyzed by inertia from the trauma of having expressed themselves when the timing hasn’t been right.',
            'When the timing is correct, Gate 12 is the ultimate wordsmith. Here we have the energized creative expression of the Knowing Circuit (see chapter 7). It can be passionate, rich, and deep in its expression, with all of the juice and fire that art and creativity can bring humanity. It can be new, transformational, and very, very influential.'
        ],
        [
            'My words, my expression, and my creation are divinely guided, and I speak the perfect words to transmit the beauty of who I am and what I create.',
            'My voice is heard and valued, and I continue to share my insights and my experiences as part of my creative process.',
            'My divine perspective supports me in evolving my ideas and creations.'
        ],
        [
            'Are you using willpower or divine power to create?',
            'Do you feel stuck or at a standstill? If so, what do you need to do to keep moving forward?',
            'Is it time to continue sharing your thoughts, ideas, and divine inspirations with others?',
            'What playful things can you do to inspire your creative energy?'
        ]
    ),

    new GateDescription(
        13,
        'The Listener',
        [
            'Gate 13 is kind of magical. It’s an energy that creates a very interesting response in the people around it. Gate 13 compels others to share their secrets with them. If a person has this energy, people will tell them anything and everything—even people they don’t know. This is the energy of the listener.',
            'When you have this energy, you are a storyteller, but most importantly a story “keeper.” Because this energy is so close to the Throat Center and is part of an expressive channel, it is easy to blurt out other people’s stories and secrets, especially if the Throat is undefined. But keeping stories is a sacred job, and one that ultimately holds the key to part of the story of humanity.',
            'With Gate 13 comes not only the energy for listening, but also the energy for giving direction once the story has been shared. This is a very special energy, one that requires compassion and wisdom. It’s good to be aware of the fact that others will perceive people with Gate 13 to be a good listener and accept that this energy is part of their life path.'
        ],
        [
            'I am a servant to the Divine. In my quiet retreat, I align with my higher purpose, and I take actions that are of service to the greater good. Each day I ask that my mind, my eyes, my words, my heart, my hands, my body, my light, and my being be used in divine service.',
            'I listen carefully to the words and true meanings of others. I allow myself to see the truth behind all words so that I always know the divine meaning of each communication.',
            'I hold a sacred space for humanity to come together to fulfill its highest purpose.',
            'I lead with love.'
        ],
        [
            'What is the status of your ego? Are you comfortable serving the higher good without recognition? Are there areas where you are still motivated by a need to prove something?',
            'What can you do to listen and truly hear others better? What do you need to do to hear and listen to your own guidance better?',
            'Are you taking time for yourself to allow for clarity? Do you see the truth of your past? What pieces from the past do you still need to release?'
        ]
    ),

    new GateDescription(
        14,
        'Power Skills',
        [
            'Gate 14 is a purely generated gate. Here we have the energy for working to make money. But it’s not only working for money, it can be responding to opportunities to generate resources. This is the energy for power skills, important social connections, and all of the things we think of when we think of wealth.',
            'There can be a certain amount of luck associated with this gate. When people with this energy respond, the response is about creating wealth in some way. Being born with this energy can be like having a natural “inheritance,” and because making money can sometimes be so easy for people with this gate, they often don’t care about the physical trappings of wealth.',
            'This energy flows into a desire to make a contribution to humanity. People with Gate 14 understand that nothing gets done on the planet without finances. But it’s not personal finance, like we see in the Ego Circuit (see chapter 8). This is merely about working for the right thing, to give it energy to ultimately be expressed.'
        ],
        [
            'I trust and know that as long as I am following my strategy, I am fully supported in all my endeavors.',
            'My unlimited capacity to create gives me support, and I use my support to fulfill my life purpose.'
        ],
        [
            'Make a list of everything you are doing right now that you find inspiring and delicious. Make a commitment to yourself to follow at least one of these inspirations each day.',
            'What would your life look like if you only followed your passion? What would you be doing? What would your life feel like? What would your energy level be?',
            'Do you trust the Universe to support you in following your bliss? Can you make money doing what you love and know that you will be supported?'
        ]
    ),
    
    new GateDescription(
        15,
        'Extremes',
        [
            'Gate 15 is a powerful, multifaceted energy. This is the gate of extremes—particularly extremes in rhythm. People with Gate 15 are always trying to find their rhythm, but it changes all the time. If they can find a consistent rhythm, it will be different and extreme. This can sometimes make relationships challenging, especially if a person with Gate 15 is in a relationship with a person with Gate 5.',
            'People with Gate 15 have a big aura. They are usually aware of it and try to hide, but they can’t. The aura of Gate 15 walks into the room before the person actually does. Everyone really is turning around to look at you!',
            'Gate 15 represents the love of humanity. The Gate 15 can lead to extreme expressions of love for humanity. This can be a martyr gate. Hopefully it is paired with Gate 10 so that it can also be about empowerment.',
            'This energy not only gives us a deep connection to our divine siblings, but it also ties us to the natural world. It is the energy for nature, flow, animals, and the elementals. The energy here clearly shows us that our fate and the fate of the natural world are inextricably intertwined. When we work with the fifteenth gate, we are called to ask ourselves what contribution we want to make to the world and to our divine siblings.'
        ],
        [
            'My life adds to the greatness of humanity. My work benefits the world.',
            'I accept unconditionally the broad spectrum of diversity and rhythm that makes up humanity, and I surrender to the larger flow of life.',
            'I am in awe of the magnificence of mankind, and my awe inspires me to be of service to the greater good.'
        ],
        [
            'Where do you have rhythm, and where do you need to adjust your rhythm to be more “in the flow”?',
            'What does the natural world seek to share with you? Do you need to align yourself more with nature?',
            'What contributions are you making to humanity? Are you acknowledging your service? Do you need or want to deepen your commitment?'
        ]
    ),
    
    new GateDescription(
        16,
        'Skills',
        [
            'Gate 16 is enthusiasm without depth (unless it is paired with Gate 48). This is the “just do it” gate; it will just do things and figure out the details later. The good news is that Gate 16 is usually imbued with natural talent and can often get away with the superficial expression of talent it carries.',
            'Gate 16 gives us the energy to leap out of bed and get truly excited about our creative endeavors. This is the gate of skills, but not so much depth, so there is youthfulness in our excitement. We still have much to learn as we master our creative process, but, like the Fool card in the Tarot, every journey starts with an excited first step.',
            'Writing Assignments'
        ],
        [
            'I allow myself to experiment and create.',
            'Experimentation and exploration are natural parts of my creative self and allow me to find the correct pattern for the expression of my talents and my soul’s journey. It is in the relentless pursuit of this journey that I live my joy.'
        ],
        [
            'What dreams are beginning to come to fruition? What is your experimentation teaching you? What do you need to tweak?',
            'What beliefs may be part of creating the manifestation of your experiments? Are there any old beliefs that you need to release?'
        ]
    ),
    
    new GateDescription(
        17,
        'Opinions',
        [
            'With the energy of Gate 17, we launch new ideas, ideas that are still to be proven. It’s an energy of curiosity, not certainty. The energy of logic is mastery over time through correction of patterns. Gate 17 is the first corrective energy we see in the Logic Circuit (see chapter 9), but it is really an illusion. Without energy for proving and mastery over time, Gate 17 is just opinions.',
            'This energy can be really hard for people to carry, especially if they are not good at waiting for people to ask. Gate 17 just plops out those opinions, not always recognizing that opinions are just ideas. Without recognition, the opinions are often energetically repelling, and the giver of the thought is ignored.',
            'Gate 17 is merely proposing an idea, and when people with this gate can learn about the beauty of their idea instead of acting with certainty that their thought is correct, they can play their part in creating collective mastery.',
            'Think of Gate 17 as the part of the scientific method that is about setting up a hypothesis. Remember that a hypothesis is a statement that is designed to be experimented with in order to see whether it is true or not. Opinions may or may not be true. They are designed to be experimented with so they are, in essence, new ideas that need to be tried out.',
            'In its lowest expression, this gate is all about blurting out opinions. In its highest expression, it is an opening for a new possibility or a new pattern.'
        ],
        [
            'I wait to offer my insights until I am asked. I know that when people ask, they will truly value my insights.',
            'I am aware that what is truth for me is not always truth for others. Each one of us has our own unique journey, and our perceptions create our understanding.',
            'I serve the truth and wait for those who are aligned with my truth.'
        ],
        [
            'What do you do with ideas and inspirations that spark your enthusiasm? Are you good at holding on to ideas and allowing the right people to be drawn to the “germinating” phase of your creation?',
            'What does the phrase “to serve” mean to you? Are you being of service? Do you want to do more? Can you serve yourself without guilt?'
        ]
    ),
    
    new GateDescription(
        18,
        'Correction',
        [
            'Gate 18 is the intuition to make things perfect. It is the gate of the editor and the accountant. This is also a splenic gate, so there is no thinking here, just intuitive understanding. And, of course, fear. The fear of this gate is that nothing will be perfect, and as with all splenic gates, there is potential for someone to shut down because they will “never get it right.”',
            'Gate 18 can feel harsh, especially if it is not recognized. There is no motor connected to Gate 18. The energy has to be recognized and called out by others. When it is asked for, it is brilliant and vital. We need people who can “fix” things and know how to make them better. They can find the perfect pattern and bring it out in a powerful way. This is the gift and the curse of Gate 18. And, of course, because it is intuitive and located close to the Root Center, often people with this gate feel pressured to share their correction. Oftentimes people will either react poorly, or they won’t listen. Sometimes we call Gate 18 the “See? I told you so” gate.'
        ],
        [
            'My entire life is a process of ever-expanding perfection. Where I am right now is the sum total of all of my experiences, and as I learn and grow, so does my understanding and consciousness.',
            'I am perfect right now. My so-called mistakes are catalysts for my growth, and I enjoy correcting patterns and bringing more and more alignment with my divinity into my life!',
            'Each and every day offers me opportunities to grow and expand, and I am grateful!'
        ],
        [
            'When you look at your life, what patterns of success are you aware of? What can you do to encourage these patterns to keep repeating?',
            'When you look at your life, what patterns of self-sabotage are you aware of? What can you do to shift these patterns?',
            'What do you need to work on releasing? Judgment? Forgiveness?',
            'In your creative process, what needs to be tweaked in order to be brought into a more aligned expression?'
        ]
    ),
    
    new GateDescription(
        19,
        'Wanting',
        [
            'This gate is very sensitive. There is a real need for emotional honesty in this channel, as the emotional sensitivity helps make the decision whether to invest in a relationship or not. If a relationship doesn’t “feel good,” it is difficult to achieve intimacy.',
            'The sensitivity of Gate 19 can manifest in many ways. It can be very sensitive to shifts in emotional energy. It is crucial that parents realize that kids with this gate must be disciplined in a very gentle way. Yelling, hitting, or other extreme emotional expressions can be very harsh for the child with Gate 19, especially if they are emotionally undefined.',
            'Gate 19 can also be very sensitive to touch and feel. Emotional energy is all about touching, and the wanting that drives intimacy is rooted in the desire to be touched or not. True intimacy has to be felt on all levels of being. With true intimacy comes the decision to invest in the formal bonds of the relationship.',
            'This can manifest as sensitive skin and tactile senses. Often people with Gate 19 will cut out the tags to their clothes, prefer soft fabrics, and even wear their socks inside out so as to avoid the seam pushing against their toes.',
            'Gate 19 can also have a very sensitive palate. People with this energy may be able to discern the difference between the taste and texture of similar kinds of foods. For example, if someone with this gate switches brands of oatmeal, they may be able to tell the difference between the manufacturers.',
            'Because Gate 19 also hooks into the mammalian chart and the energy of animals, it is often sensitive to the energy of animals. People with Gate 19 often benefit from having a pet as a companion.'
        ],
        [
            'I know that the ending of cycles is always the beginning of the new. I take the blessings and the lessons I have learned from this cycle and move forward courageously into the next.',
            'I honor my sensitivity and trust my feelings.'
        ],
        [
            'What cycles in your life are coming to an end? What lessons have you learned from this cycle? Where have you gained clarity?',
            'Are you resisting or allowing these conclusions? Is there anything you need to do to create space for the beginning of a new cycle?',
            'What does intimacy mean to you? Are your needs being met? Are you meeting the needs of your partner? Are you asking clearly for what you want? Are you allowing your partner to give to you?'
        ]
    ),
    
    new GateDescription(
        20,
        'Metamorphosis',
        [
            'Gate 20 is powerful. It brings the entire Integration Circuit (see chapter 7) to the Throat, which dictates the expression (or not) of intuitive awareness to right action. Gate 20 has the potential to meet with empowerment, the self, intuition, power, and life force in a mutative way. It is an individual voice that can mutate and empower, or stagnate and disempower. (Remember, not all individual voices can be adaptive.)',
            'When Gate 20 exhibits its highest potential, it is the expression of integrity—doing the right thing even if it isn’t what others are doing. This can mean wearing green face paint in the forest when others are wearing bright pink or any other kind of “right” action that may be going against the flow.',
            'Because Gate 20 is the expression of integration, it has within it inherent wisdom. In traditional I Ching, the twentieth hexagram is the wise king standing on a hill, watching the wind to see which direction it will settle on before he takes action. As part of integration, Gate 20 takes time to express its wisdom. It watches and waits to express its higher knowledge, insight, and awareness. It metamorphoses awareness and recognition into action.',
            'Gate 20 also recognizes the talents and skills of others. It is the great art critic or publisher, intuitively knowing the highest expression of awareness and self-expression. Gate 20 gives us one of the most interesting and counterintuitive dilemmas in the chart. We are deeply conditioned to believe that power and charisma are forceful energies, energies that aren’t recognized without assertion or even aggression.',
            'The Human Design chart shows us that the highest expression of power, charisma, and leadership is expressed only when recognized. Dictatorship and pushing your manifestations don’t really work and usually only repel people.',
            'True power lies in waiting for right timing, the right recognition, and preparing while you wait. People with this gate should take some time to align their desires, actions, and mindset. Plant the garden of your mind with the right seeds of thought, and fertilize with faith, trust, and knowingness. Let Divine Order prevail. Gate 20 promises that not only will the right chances materialize, but the right people will also be joined together in the process.'
        ],
        [
            'Just because I can do it doesn’t mean that I have to or that I should. I use my strategy to determine my actions, and I only do the things that are correct for me.',
            'I am a door to cosmic perfection and the entrance point for actions that create Divine Order. It is in my not doing that my doing becomes evident.'
        ],
        [
            'How do you feel about not doing?',
            'Are there places in your life where you are busy without direction?',
            'Are you battling burnout? Are you being as effective as you’d like to be?',
            'Are there places in your life where you need to take leadership and delegate?',
            'Define your personal power. Are you fully activating it?'
        ]
    ),
    
    new GateDescription(
        21,
        'The Treasurer',
        [
            'Gate 21 is the gate of the treasurer. It is here that we see the ultimate control of resources. This is a highly material channel that wants to control physical resources.',
            'People with this energy love their things. They might buy a new car and park it way at the back edges of the parking lot in order to avoid door dings. Gate 21 can seem very controlling to others. Even though this energy has the potential to meet the Throat, on its own it is projected, meaning people won’t allow themselves to be controlled unless they ask for it first.',
            'When recognized, Gate 21 is a valuable resource for others. The wisdom of Gate 21 tells us when and how best to use our resources and spend our money.',
            'While we may resist the control of Gate 21, it is a vital energy for sustainable abundance. Nobody likes a good treasurer, but everyone loves a full bank account.'
        ],
        [
            'I control my thoughts and my actions. I release my need to control others.',
            'I use my energy to manage myself and trust that the Universe will provide all the serendipitous encounters and magic necessary to manifest my desires.',
            'My inspiration is a source of inspiration for others. I lead by example.'
        ],
        [
            'What things in your life do you need to let go of your control over?',
            'What do you need to do to allow others to express themselves and to hold a space for their freedom?',
            'What do you need to do to deepen your trust of Source? What old beliefs and fears need to be released so that you can move more deeply into Trust?'
        ]
    ),
    
    new GateDescription(
        22,
        'Openness',
        [
            'People with this energy can be very graceful and charming if they are in the mood. They know how to “work the room” and can be great fundraisers and sponsors. The true blessing in this gate comes from the realization that beauty and grace come from within, and that sharing this inner world needs to be done only with those who are willing to wait and cherish them. When inner beauty and grace are mastered, the right beholder recognizes the beauty and creates space for its expression.',
            'Not understanding the inner world of beauty can become disgraceful. Acting on impulse, speaking out of turn, or improperly emoting can create an energy that pushes people away and removes the opportunity to transmit beauty. The person with Gate 22 needs to wait for correct timing and also inform before sharing.',
            'With maturity, there is great wisdom, and this gate can learn to share when it’s correct or silently sit and listen when it’s not the right time. When it lives from true grace, this energy is compelling and gains attention.'
        ],
        [
            'In the face of Divine Order, I stand with grace and presence.',
            'I see and evaluate, integrate, and share my awareness. I articulate the conclusions with grace and correct timing.',
            'I use my ability to perceive correct awareness to bring my awareness and understandings to others.',
            'I am the calm within the storm.'
        ],
        [
            'When faced with the emotional energy and drama of others, what is your strategy to allow and be aware? What are your strategies for detaching?',
            'What is your style of teaching? When you recognize patterns, how do you bring your understanding forth?',
            'Where do you create drama? How do you feel about your emotional energy? Do you wait for clarity, or do you jump in and clean up afterward?'
        ]
    ),
    
    new GateDescription(
        23,
        'Assimilation',
        [
            'Gate 23 can be a real game-changer, as it recognizes that all foundations can be split apart with new thoughts and awarenesses. The real power to transform and serve as a catalyst for evolution lies in the capacity of Gate 23 to wait for correct timing. With correct timing, an invitation, and recognition, the words of Gate 23 can change the world—or at least the world of the person they are sharing their life with. If Gate 23 waits until the time is right, its insights can be perceived as genius. If Gate 23 does not have good timing, it can be perceived as “freakish” or ineffective.',
            'Gate 23 continues the translation process of Gate 43. Gate 23 has the job of actually finding the words to express the mental mutation of the Knowing Circuit (see chapter 7). The gift of Gate 23 is that it can split apart the ideas of Gate 43 into small bits that can be articulated.'
        ],
        [
            'My greatest strength is my ability to be still and wait to be asked to share the vision I hold.',
            'I stand with great confidence in my knowingness, and I trust that I know and hold the intention to create dynamic change for my own good and for the greater good of the whole.'
        ],
        [
            'How do you hold your vision? What part of your daily practice supports you in holding the energy of your intention?',
            'Do you have the courage to hold on to a vision, even when no one else “gets it” or understands it at the moment? Is it okay for you to be on your own with your intention? How do you feel about not fitting in? When do you quit? When do you hold steady?'
        ]
    ),
    
    new GateDescription(
        24,
        'Rationalization',
        [
            'Gate 24 is the energy for rationalizing. In the mutative process, Gate 24 says “two steps forward and one step back is still one step forward.” The more you study Human Design, the clearer it will be that every step of expansion is followed by a contraction. We never go back to our original placement, but there is a grounding of expansion that allows for its correct progression. I lovingly call this “re-tweaking.” Gate 24 has the ability to find what truly works in the knowingness of Gate 61 and creates focus in that direction.',
            'It is a powerful energy for moving forward that requires focus, intention, and a precise letting go of the mutations that are not adaptive. With this energy, we can rationalize what has been and what is, and make the best of it to create something new.',
            'The rationalization of Gate 24 is also projected. The rationalization has to be invited to be shared and adapted, otherwise we think it’s crazy or dysfunctional. You actually can rationalize anything. With an invitation, the rationalization of Gate 24 is reasonable and functional. Gate 24 is auditory, mutative, and also melancholic. Sometimes it’s hard to rationalize, even though you can.'
        ],
        [
            'I give my attention to my progress and all that is good.',
            'I focus on what is working, what is aligning, and I trust that all that is good will grow.',
            'I celebrate my successes and focus on creating more success by simply attending to that which is correct for me.'
        ],
        [
            'Make a list of everything that feels good and is working in your life.'
        ]
    ),
    
    new GateDescription(
        25,
        'Love of Spirit',
        [
            'We move from the shock of initiation into the love of Spirit. Here we have a sweet, loving energy that has absolutely no shock in it. This is pure love, and you feel it when you stand in the aura of this energy.',
            'The challenge for people with Gate 25 is understanding why other people do the things they do. When someone with this gate witnesses something they perceive as not loving, they can be confused. But if they try to speak to the situation, they cannot change it. The challenge of this energy is to be love while refraining from spreading love unless invited. Again, there is no convincing or talking here—only being.',
            'Gate 25 has very powerful healing abilities. If you have this energy you are a natural hands-on healer and do not necessarily need any training. When you have an open Spleen and Gate 25 you are natural healer and medical intuitive who can heal with the power of love. Truly, the twenty-fifth gate tells us that what the world needs now is love, sweet love, for everyone.',
            'The energy of Gate 25 asks us to surrender our human understanding and judgments and embrace the concept of a love that is bigger than all of us.'
        ],
        [
            'I am perfectly prepared to take my place in Divine Order.',
            'I know that my intentions can and will be fulfilled according to divine mind, and I relax and trust.',
            'I know that there are greater unexpected outcomes that are for my higher good, and I trust that all is well.',
            'I turn a blind eye to how things look and know that the truth will be revealed to me when I need to know.',
            'The spirit of God within me is the source of all my good.'
        ],
        [
            'How much do you trust in Divine Order?',
            'For any given challenge in your life right now, ask yourself, “What would love do?”'
        ]
    ),
    
    new GateDescription(
        26,
        'The Trickster',
        [
            'Here we have the gate of the salesman. Gate 26 has the energy to orchestrate the closing of a deal. It has the energy to transmit that the dream is a great idea and should be “bought” by the tribe. The tribe then, of course, delivers the resources to bring the dream into form. Gate 26 can be tricky, though. The energy here is truth or not. A good salesman will sell you a good dream and fulfill the promise. But the energy here is about sales. Sometimes a salesman will sell just to sell, and then he ends up being a snake-oil salesman.',
            'The ultimate expression of this gate is about integrity. Gate 26 will express the lessons from the past and has the power to shape the identity of the tribe based on how it presents the past. Think about it. History is mutable. This gate can make history be whatever it wants it to be and then presents that version to the tribe.',
            'Of course, this gate is also connected to the Will Center. So now we see a break in the workaholism. The ego doesn’t need much recognition, just enough and then it’s time to rest. The trickster gets you to give him money so he can run away and rest. Or he will sell the dream, get it started, and let others do the hard part. (Think of the salesman from The Music Man who sells a set of imaginary instruments to a group of naïve small-town people.) This is, after all, just sales. The contracts and finances for deals are contained in other parts of the circuit.'
        ],
        [
            'I speak and act with integrity, and I share my heart freely with my loved ones.',
            'I take my time to speak the perfect words because I know that my words are representations of my heart and my inspirations.',
            'I care deeply about my impact, and I listen with love to those around me.'
        ],
        [
            'Are your actions and words in alignment with your intentions?',
            'What do you need to do to bring them into alignment?',
            'What truths do you need to share from your heart? What heart-to-heart connections do you want to make this week?',
            'What do you truly value in your life? Are you sharing your appreciation?'
        ]
    ),
    
    new GateDescription(
        27,
        'Responsibility',
        [
            'The caring of Gate 27 is all about responsibility and education. A well-fed tribe has optimal neurological development, which allows everyone to continue to live out the values of the tribe. Gate 27 has a responsibility to transmit the values of the tribe through education and disbursement of resources. It delivers the food and teaches the tribe how to grow and distribute more.',
            'This is not a relaxed energy. This is tribal energy, after all. The pressure of responsibility is undeniable, and the transmission and nurturing can happen at great cost to the individual but can reap great rewards for the tribe.',
            'This is the energy of Mother Teresa: caring, responsible, impactful, and educating; sacrificing the individual for the greater good of the whole.',
            'A healthy expression of this energy gives you the power to own what is yours and to hold others accountable for their responsibilities.',
            'Remember, you cannot force someone else to evolve. They have to choose to evolve for themselves. If you are trying to be responsible for someone else’s happiness, you will just waste precious energy and give up your own happiness in exchange.'
        ],
        [
            'I trust that when faced with challenges, I will know exactly what to do.',
            'I take care of myself and then others so that my energy is strong and my capacity to care is limitless and empowering.',
            'I empower others to assume responsibility for what is theirs and see them as fully capable.'
        ],
        [
            'Are you doing things for others that they could be doing for themselves? What actions do you need to take to empower them and you?',
            'What is your core message in your life right now? Where do you need to focus your energy to fulfill the transmission and manifestation of that message?',
            'Are you dependent on the approval, permission, or recognition of others? Are there any people in your life that you need to stop trying to keep happy?',
            'Could you be better about taking care of yourself? If so, what do you need to commit to?'
        ]
    ),
    
    new GateDescription(
        28,
        'Struggle',
        [
            'Gate 28, the gate of the game player, is a splenic energy that is rooted in the fear that life has no meaning or value. Gate 28 has to struggle to discover that meaning. But it has to be the correct struggle—otherwise it is meaningless.',
            'Sometimes people with this energy will feel that life is not fair. It may seem like life is so much more difficult for them than it is for others. To a certain degree, if people with Gate 28 are not following their strategy by type, this can be true. Gate 28 gives a chart a default program of struggle. If you have this energy and you live your strategy, you will engage in the correct struggle, and these struggles will help you discover and share the meaning of life. But if you don’t live your strategy, it’s possible you will focus on the wrong struggles, which just makes life feel hard.',
            'When you don’t have Gate 28, it’s hard to imagine that struggle can be fun. But people with Gate 28 can actually learn to embrace the struggle. When the value of life has been mastered, Gate 28 enjoys the challenge. They like pushing the envelope. This is joyful engagement in the challenge of life and taking life to the extreme.',
            'The struggle is challenging, but surmounting the struggle has tremendous payoff with this gate.'
        ],
        [
            'I am fully alive. I am constantly present to the energy and possibility of life.',
            'My experiences and struggles help me define what is truly valuable in life, and I love the challenge!'
        ],
        [
            'We often ask ourselves what we can pursue that is worth dying for. Instead, try asking yourself: What in your life is worth living for?'
        ]
    ),
    
    new GateDescription(
        29,
        'Perseverance',
        [
            'Gate 29 has a tendency to say yes to everything, especially when it is not using the Sacral strategy of response. Gate 29 is designed to be perseverant and determined, and part of that expression is the commitment to do.',
            'When Gate 29 is not living its strategy, it can commit itself to death. It is not uncommon to see autoimmune disorders and physical symptoms of burning out when Gate 29 is not responding. Gate 29 seeks commitment, but it must be the right commitment. When it responds, it carries the energy of being able to withstand the trials and tribulations that can lead it to success. But the wrong commitment can make Gate 29 hold on for longer than is healthy. This can be a bad combination, especially with an open Spleen, open Emotional Solar Plexus, or open Will Center. Too much holding on, proving, or empathy can wear Gate 29 down.',
            'The power of Gate 29 lies in its ability to persevere no matter what. This is the commitment and the determination of the Olympic athlete or anyone who is determined to make a dream a reality.',
        ],
        [
            'As I prepare myself to emerge from my creative cocoon, I carefully examine my actions and make sure that my commitments are in alignment with my intentions.',
            'I only say yes to the things I know will bring me closer to fulfilling my dreams, and I enter into my commitments according to my Human Design strategy.'
        ],
        [
            'Are there areas of your life where you have outgrown your commitments? What circumstances and situations do you need to release to make room for new commitments?',
            'How hard is it for you to say no? What keeps you from saying no to yourself or to others?'
        ]
    ),
    
    new GateDescription(
        30,
        'Desire',
        [
            'Gate 30 brings us the energy for intensity and desire. In the traditional I Ching, this energy is called the clinging fire.',
            'The theme of this channel is to wait for the right timing to express or take action. Gate 30 gives us the energy to hold on to an idea and let it simmer until the timing is right. Gate 30 has an intense tenacity that can often drive other people insane or burn them out. But when acted upon correctly, it gives us the passion and the drive to manifest the next new experience.',
            'Gate 30 is all about creating new experiences. New experiences can be life-enhancing or chaotic, or maybe a little of both. Waiting for the right timing is crucial, but it is also challenging for this gate in particular. It’s under pressure. It has desires. It longs to express itself. It’s emotional. It’s juicy.',
            'If this gate wants to express itself correctly and not push others away with its intensity, it has to wait and be mindful of the fact that most other people will not be so intense.'
        ],
        [
            'I am clear about my intentions and desires. I only focus on what I want. My vision is true, and my passion is fed by the fire of my heart. I am unwavering and powerfully focused.',
            'I honor myself for creating the space to bring forth my dreams and intentions.',
            'My life is completely open to receive, and I stand in a passionate place of anticipation for the manifestation of my desires.'
        ],
        [
            'What do you want in your life? What do you choose to experience in your finances, your health, your relationships, your creative fulfillment, your spiritual life, and your lifestyle?',
            'What distractions do you need to remove in order to keep your focus sharp?',
            'What are you passionate about? Are you free to express your passion? What keeps you from your passion?'
        ]
    ),
    
    new GateDescription(
        31,
        'Democracy',
        [
            'With Gate 31 we have natural leadership that must be recognized in order to be effective. This is the expression of democracy … leadership that has been proven effective over time through repeated applications of theory. This gate serves best when it seeks to serve the people. The best question to ask yourself if you are working with this energy is, “How may I be of service?”',
            'Let the group you are leading tell you how they want to be led. This is the real secret to being an effective leader with this energy. You are simply the figurehead. Unify the group, and be ready to delegate and share the power.'
        ],
        [
            'I assume my position of natural leadership when I am invited to assume influence.',
            'My words, thoughts, ideas, and dreams are important and worthy of sharing with the right people.'
        ],
        [
            'Meditate on what true power and influence mean to you. Notice where you feel power in your body, and practice connecting with this physical feeling at least once a day.'
        ]
    ),
    
    new GateDescription(
        32,
        'Continuity',
        [
            'Gate 32 is the intuition to know when a dream is worth bringing into form and reality. Gate 32 wants to provide the energy to make it happen, but it has no energy of its own. Here we have the intuition and wisdom to know that something could be transformative and successful, yet the entire process rests on whether or not someone recognizes the value. It requires an enormous amount of trust. Gate 32, rooted in the Spleen, is a fear gate. Gate 32 says, “What if my dreams are all for naught?” Gate 32 has a tremendous fear that someone else will take their dream and make it a success or that if they implement their dream, they will fail.',
            'In its high expression, Gate 32 is an evaluator but not a doer. The true power of Gate 32 is in recognizing which ideas are worthy of energy expenditure and which ideas can simply be released.'
        ],
        [
            'I intuitively know which ideas are worth pursuing.',
            'I am wise about what will work, what will create resources, and what needs to happen to turn a dream into a lucrative and impactful endeavor.',
            'I trust that the right people and the right resources will be attracted to me so I can easily share my wisdom in a way that values me and my ideas.'
        ],
        [
            'What would an unlimited life look like to you? What would you do? What would your business look like?',
            'What leaps of faith would you need to take to make this dream life a reality? What new commitments would you need to make?'
        ]
    ),
    
    new GateDescription(
        33,
        'Privacy',
        [
            'Gate 33 innately recognizes that the stories of people’s lives are sacred and vulnerable. This is where memory is stored. Gate 33 takes the energy of the witness and holds on to the memory, only sharing the memory if the timing is correct.',
            'The danger with this energy is that in its lowest expression, it holds on to the past, fearful of the possibility of it repeating itself. This can cause someone with this gate to become stuck, fixated on what’s already happened—especially if they are not waiting for the recognition to share their story. The stories of the past require time for reflection in order to discover the right way to share in accordance with the sacredness of the memory. It is in the aloneness that Gate 33 realizes what needs to be shared and what needs to be released, forgiven, and forgotten.',
            'In its highest expression, Gate 33 shares the stories from the past, maintains the memories and the history of the collective, and shares when the timing is correct.'
        ],
        [
            'I continue my journey inward, working with the cycles of creation and repose.',
            'My focus now is on my past, my journey, and the evolution of my future.',
            'I relax and trust that what is hidden will be revealed and truth will be demonstrated. My greatest power is in divine timing.',
            'I trust. I wait. I know. I grow.'
        ],
        [
            'If you have not seen the results of forward momentum in your life that you have intended for this year, what do you think is holding you back? What storyline are you living? Write the story of your limitation or label.',
            'Rewrite that story as if it weren’t true for you anymore. What would change? What would the end results be?'
        ]
    ),
    
    new GateDescription(
        34,
        'Power',
        [
            'Gate 34 is the busiest gate in the chart, and one of the most powerful. Because it is rooted in the Sacral, it is generated energy-and life force-based. This is the only gate coming out of the Sacral that has the potential to be asexual. Sometimes people with Gate 34 can be too busy to have sex. (Or they can be very busy having sex.)',
            'Gate 34 is the base gate for the Manifesting Generator, so it has the potential for great power, but there is an irony associated with the power of Gate 34. It is powerful only when it responds. It is generated, not manifested. Generators with Gate 34 who push and initiate their power will not be successful in the expression of their power, and consequently will feel very frustrated.',
            'Generators with this energy often have a hard time distinguishing between pushing and manifesting. The wiring in this part of the chart is so complex and fast that sometimes it’s hard to slow down enough to see if you’re responding. It’s good for people with this energy to practice visualizing the outcome of their choices before they leap into things.',
            'Gate 34 is the “multitask” gate. A person with this gate is designed to have many things going on at once, and it is crucial to look at where Gate 34 connects in a chart. This will determine the expression of Gate 34.',
            'People with Gate 34 are often told to slow down and to pick one thing and stick to it. That’s good advice for some people, but not for people with this energy. Gate 34 has to be busy. If it’s not busy, it’s like trying to trap a lightning bolt in a glass jar. Eventually, the lightning bolt will ricochet around in the person’s body and hurt their health.',
            'If a non-Sacral person has Gate 34, when their Sacral gets under pressure they will be the busiest people on the planet, but not sustainably.'
        ],
        [
            'I trust the Universe to deliver the perfect opportunities to fulfill my dreams and intentions.',
            'I watch and wait for signs that clearly show me the next step.',
            'I know that my true power is in co-creation with the Universe, and I know that divine mind has the perfect path for me.',
            'Being busy is healthy for me, and I honor my need to do many things at once.'
        ],
        [
            'How are you leveraging your power and energy? Are you doing things that are not bringing you closer to your dreams? What things do you need to stop doing in order to create a space for what you truly want?',
            'What is your definition of power? Do you feel powerful? What can you do to be more powerful in your life?',
            'What do you need to do to deepen your trust in the Universe? Are you showing up and doing your part in your life?'
        ]
    ),
    
    new GateDescription(
        35,
        'Change',
        [
            'Gate 35 is the final expression of experiential energy. This energy follows fantasy and desire. It’s tried everything, had every experience, and it is capable and sometimes jaded.',
            'There is a maturity rooted in experience with Gate 35. It knows life and knows how to learn what’s necessary. People with Gate 35 are rarely stymied about life. They understand the life experience and can, with little hesitation and limitation, learn just about anything.',
            'The challenge of Gate 35 is finding an experience that can light it up and turn it on. Gate 35 is not inspired by the mundane. It seeks the experience that is worth its investment in time, energy, and resources. Gate 35 offers stories of life rooted in personal experience. You never know what story a person with Gate 35 may be waiting to tell. In the mature expression of this energy, Gate 35 knows that the real gift of the story isn’t in the excitement, it’s in the process, the emotions and the lessons learned. There is great wisdom here, and the stories of Gate 35 ultimately belong to all of us. They’ve done it all so we don’t have to.'
        ],
        [
            'I choose the kinds of experiences I desire.',
            'My feelings about my experiences show what is correct for me.',
            'I am responsible for my own choices and my own happiness, and no one can create experiences for me that I do not choose.'
        ],
        [
            'What is going on in your life right now that you would like to change?',
            'In your current manifestations, what experiences would you like to avoid duplicating? How can that understanding help you get clear about your creation? What experiences do you need to focus on and align with?'
        ]
    ),
    
    new GateDescription(
        36,
        'Crisis',
        [
            'Gate 36 is the emotional impulse of desire. Gate 36 wants what it wants, and if it waits, it can have it. If it doesn’t wait, it leaps into chaos and crisis. Gate 36 is always longing for the next new experience. It is plagued by boredom and has a tendency to leap into things without waiting for clarity purely in pursuit of the next new experience.',
            'If the desire of Gate 36 is to be a master of some kind, it needs to learn to temper its restlessness so it doesn’t quit something before it masters the skills necessary for success. Gate 36 is all about desire and can be quite sexual in pursuit of fulfilling its desires. What we learn from the Human Design chart is that all sexuality is designed to be waited for and not acted upon impulsively, as the consequences of acting too quickly can be dire.',
            'This is the gate that teaches us to temper our fires with time and even a bit of pragmatism. There is great value in learning to wait for the right timing.'
        ],
        [
            'I embrace the new.',
            'I trust my intuition and my strategy, knowing that I make clear, intentional choices.',
            'I am the eye of the storm. My head is clear, my heart is aligned, and I only act for my highest good.',
            'I am immune to the appearances of my outer reality, and I know that I am on my way to creating what I intend. My beliefs are unwavering, and I am not swayed by outer circumstances.'
        ],
        [
            'What is your strategy for coping with unexpected events, chaos, and tragedy?',
            'How strong is your connection to Source? What do you need to do to strengthen it?'
        ]
    ),
    
    new GateDescription(
        37,
        'Friendship',
        [
            'Gate 37 is a very clear and simple gate. It wants one thing and one thing only: harmony. Gate 37 will work for peace and, if the timing isn’t correct, wait for peace. Gate 37 on its own seeks to join with others and communicate to create peace and harmony.',
            'At the root of Gate 37 is the belief that when we all work together to create the resources necessary to sustain us all, then we will have sustainable peace. It is half of the Channel of the Bargain (see page 259) and is all about creating agreements and contracts. The intention of Gate 37 is to create agreements that foster peace and harmony.',
            'If you do not communicate clearly with those around you, you run the risk of misunderstandings, which can hinder your progress. Whatever level this communication takes place on, you need to make sure that you are respectful, sincere, and very clear in what you mean.'
        ],
        [
            'After the storm there is always calm. It is in the quietness that follows shift and change that I remember my bearings, breathe deeply, and realign my relationships with what is new.',
            'All agreements I make are clear and created with peace as the end goal.',
            'From the remnants of the past I discover my blessings, and I work with my friends, my family, my tribe, my community, and my world to co-create a mutually respectful and deeply honoring peace.',
            'Peace is within me. I am peace. I breathe peace. I create peace. All is well.'
        ],
        [
            'How can you create a lifestyle that is more peaceful? Commit to doing five peace-enhancing activities today.',
            'Are your agreements with your partners clear? Do all parties have the same expectations? Are there any clarifying conversations you need to have to deepen the awareness and clarity of your agreements?'
        ]
    ),
    
    new GateDescription(
        38,
        'The Fighter',
        [
            'Gate 38 struggles to know what is worth fighting for. It seeks purpose and meaning to life and essentially pushes us (with adrenaline energy) to find our life purpose. Why are we here, and how can we live a life that reflects our purpose? What are the truly valuable things in life?',
            'People who have this energy can be somewhat stubborn by design. When they have determined that something is valuable, they hold on to it, fight for it, and don’t let go. They’re people who can transform the world with their mutation if it survives the struggle.',
            'This energy can also be somewhat provocative. This is projected energy, so it is designed to get our attention. We watch people with this energy struggle, and we either call them out to share what’s happening with them, or we push them away and question their life choices.',
            'There is a possibility here of feeling like you don’t fit in, that life is a struggle and you’re all alone. But wait for the invitation for the correct struggle, and Gate 38 will show what is worth fighting for and will help you to find the right people to share your wisdom with.'
        ],
        [
            'I have deep clarity about my life purpose and direction. I persevere and fight for what I know has value.',
            'Serving my purpose inspires me and gives me the energy to take powerful steps forward in my life no matter what comes my way.',
            'I am here for a unique purpose, and I honor that purpose by setting clear intentions and taking actions that reflect that purpose.'
        ],
        [
            'Please visit the following website for a special Life Purpose Guided Meditation: www.understandinghumandesign.com. After you’ve completed the meditation, write about any insights you gained during the session.'
        ]
    ),
    
    new GateDescription(
        39,
        'Provocation',
        [
            'Gate 39 holds a deeply emotional and rich energy. People with this gate can be very musical, creative, and passionate. This gate is challenging and provocative. The provocation can be lighthearted, teasing, and fun, or it can poke you, stirring up negative emotions and fear. Consequently, Gate 39 can be a little tricky for the people who have it and for the people who are affected by it.',
            'Gate 39 pushes us toward abundance. The provocation of Gate 39 is designed to restore our awareness of abundance and Spirit. We sometimes refer to people with Gate 39 as our “teachers”; they are people who have pushed us and poked us in ways that have made us uncomfortable and forced us to look beyond the immediate appearances of things.',
            'On a more mundane level, the energy of Gate 39 can create eager shoppers, always on the hunt for a great bargain. People with Gate 39 feel good when their pantry is full (or even overflowing), and will often be nervous if they have to break into their stores of food. Often people with this energy will hoard and save things to a fault. They can be fearful that someday they may run out of something.',
            'In its highest expression, Gate 39 pushes us out of thought forms and habits that keep us stuck in the idea that there is “not enough.” Gate 39, as provocative as it can be sometimes, has the power to help us see that the perception of “not enough” is an illusion and that with a shift in awareness and by refocusing on the abundance of Spirit, there is always more than enough.'
        ],
        [
            'I wait for the right spirit of things, for the right doors to open, before I progress forward.',
            'I recognize the power of my actions and words to provoke others, and I use this power with great care, knowing that I have the ability to create change in people’s lives.'
        ],
        [
            'Describe a memory when the spirit felt right and a correct manifestation followed. Reconnect with that feeling and anchor it deep within your body and your consciousness.',
            'Do you push people and opportunities away? Is it correct for you? Do you need to find more constructive ways to allow yourself more time to make decisions? What can you do to create an energy that is “allowing”?',
            'What is your relationship with food like? Are you an emotional eater? Do you love your body? Are there changes you need to make in your relationship with food and your eating lifestyle?'
        ]
    ),
    
    new GateDescription(
        40,
        'Loneliness',
        [
            'Gate 40 is one of the “alone” gates and requires a deep willingness to accept that its energy is “not personal.” People with Gate 40 need alone time but can also struggle with loneliness.',
            'The energy of Gate 40 can feel deeply alone and lonely. But the truth of Gate 40 is that it drives a person to seek out others. In other words, Gate 40 is the energy of a part seeking a whole or a loner seeking a tribe. Gate 40 needs a tribe to spread and share resources with. Often we find Gate 40 in charts with a lot of mutative (individual) energy, creating the electromagnetic pull to find more tribal energy to share the mutation with.',
            'People with Gate 40 need to look for the evidence of love and companionship surrounding them. It is very possible for people with Gate 40 to be standing on a pedestal surrounded by a crowd of bowing, adoring fans and still feel as if no one wants or loves them. This energy may feel lonely, but reality will show that this gate is not as alone and unloved as it thinks it is.',
            'The loneliness of Gate 40 causes people to go out in the world and create new agreements and bonds so that the energy for creating resources is always renewed and evolving. In this way, Gate 40 plays a vital role in the energy of spreading new ways of forming agreements.',
            'Gate 40 is also the gate of the stomach. People who do not understand this energy and try to use Will energy they do not have will often have stomach problems. If a Generator has an undefined Will Center and Gate 40, they will often work and work and work and forget to eat.',
            'The undefined Will Center with Gate 40 will often try to get away from a defined Will Center because the pressure of the defined Will Center will activate the need for aloneness with Gate 40.'
        ],
        [
            'I relax in my knowingness that I am lovable and capable of allowing all the helping hands I need to make my dreams a reality.',
            'I seek out others and connect with an open heart and pure joy and love.'
        ],
        [
            'What is the nature of your relationships? Do your relationships feel balanced?',
            'Do you feel lonely? Do you need to go out and make more connections with others? Network? Join social groups? Are you connecting with the family of man?'
        ]
    ),
    
    new GateDescription(
        41,
        'Fantasy',
        [
            'Take a look around you. Everything you see that was created by man was once an idea, an idea that was manifested into form.',
            'The Human Design new year starts with this gate. This is an initiating energy that ultimately brings new ideas or experiences into form. This energy can sometimes be experienced as daydreaming. Children with this energy are often accused of not paying attention while they fantasize about their abundant ideas.',
            'The energy of this gate is well-suited for visualizing and imagining. While these are somewhat “mental” activities, what makes Gate 41 unique is that when the timing feels correct, Gate 41 can take action. Gate 41 is an idea that is waiting for the right timing so that it can be expressed into action.'
        ],
        [
            'My mind is my most creative tool. When I am inspired, I have the ability to hold on to the vision of what I intend in a steadfast and focused way.',
            'My ability to hold my intention is my greatest creative blessing. I never falter. I never waver. My eye is pure and my vision is clear.',
            'What is manifest in my outer reality is of no consequence to what I am creating.',
            'I am grateful for the signs that I am on my way to creating exactly what I intend.'
        ],
        [
            'How is false fantasy keeping you from seeing the truth? Are there circumstance in your life that you need to release in order to create what you truly intend?',
            'Are you communicating clearly? Are you listening with intent? Are there places where you need to clarify your intentions to others?',
            'Where do you lose your focus? What distracts you from believing you can have what you intend?',
            'What can you do to stay true to your vision? What do you need to do to anchor your intentions?'
        ]
    ),
    
    new GateDescription(
        42,
        'Finishing Things',
        [
            'Gate 42 is the gate of coming into the middle of a situation or experience and finishing it. Gate 42 can be an excellent project manager or consultant, provided the start-up phase of a project is complete when they enter into it.',
            'Gate 42 (like Gate 53) can feel deeply frustrated when it is not responding to opportunities to finish things. The correct energy for starting will manifest when Gate 42 is waiting to respond to the right experience. With the correct response comes the energy to get things started and finished. Without waiting, there is only frustration and adrenal burnout.',
            'With this energy we can sometimes feel pressure to complete things. Tune in and be sure this is a deliberate action. With clarity, you can create abundance in your life by making room for something new. But first, finish what needs to be finished.'
        ],
        [
            'I embrace all the change that has come before, and I recognize that all endings are new beginnings.',
            'I open the door for the new and re-dream what is to come.',
            'I am fully prepared to lay down the physical manifestation of the foundations of what is new and to take the actions necessary to bring what is new into form.'
        ],
        [
            'What final steps do you need to take to release the energy of this first quarter? What doors do you see opening? Closing?',
            'What clarity have you gained since the beginning of the year? How has that clarity helped you define what you truly want?',
            'What action steps do you need to take to bring this into form?'
        ]
    ),
    
    new GateDescription(
        43,
        'Insight',
        [

            'The highest expression of this energy is the power to see an alternative to old ways of doing things and to create a new, empowered means to a high-minded end. Gate 43 states that the ends and the means must match. The ends cannot justify the means if the ends are destructive and damaging. It is the gate of the inner ear and listens internally to what is correct.',
            'Gate 43 must wait for the right opportunity to express its breakthrough. The biggest challenge is to not bend to the pressure to try to articulate before the timing is correct. Without proper timing, recognition, and an invitation to share what it knows, the “breakthrough” of Gate 43 fizzles into nothingness, generating loneliness, rejection, and pain.',
            'Gate 43 is also one of the gates of aloneness. Gate 43 needs time alone to think and wait. This is crucial for the health of Gate 43.'
        ],
        [
            'I take time to enjoy my thoughts. I allow myself to begin to formulate new ideas and inspirations that can create change in my life and in the lives of others.',
            'My thoughts and ideas are valuable, and I trust that what I have to share is valuable to the right people.',
            'I attract the right support, circumstances, and opportunities that align with my new ideas.'
        ],
        [
            'Take some time to do a “brain dump” of all your current thoughts, ideas, and inspirations. Can you see a pattern of something new emerging? Are you on the cusp of a breakthrough?'
        ]
    ),
    
    new GateDescription(
        44,
        'Energy',
        [
            'Think of a car sales lot. The greeter welcomes you and shows you around from the moment you set foot on the lot. Maybe she even brings you a nice hot coffee, takes you to a beautiful lounge, and lets you stroll amongst the shiny models parked inside the building while you wait for a salesman. You have just been primed for the sale. Gate 44 is the greeter.',
            'Gate 44 is part of the energy of sales. It creates the atmosphere that enhances the closing of a sale. Gate 44 makes things “look good.” They create beautiful materials that sell. Many graphic designers and marketers work with this energy.',
            'Gate 44 is also the gate of smell. The intuitive smelling of Gate 44 comes from the ability to “smell” the truth (or not). Gate 44 can smell a “rat” or a “thief.”',
            'Gate 44 is imbued with the energy to “sell” the messages from the past to the tribe. Gate 44 can make a good case when necessary. It contains the intuitive awareness of whether the past is worth repeating or not, and it can tell you when the past is about to repeat itself. The highest expression of Gate 44 is to bring the lessons from the past into the present so that we don’t repeat the same mistakes.'
        ],
        [
            'I move confidently into the future, knowing that my past has been my greatest teacher.',
            'I am not limited by my past, but rather liberated from it, and I realize that now is the most powerful moment of my life.'
        ],
        [
            'Are there places where you limit yourself because of things that have happened to you in the past?',
            'Are you in full integrity when it comes to leading or influencing others? Do you walk your talk?',
            'Are there places where you need support from others? Imagine your perception of your life from your deathbed. What things would be important to you?',
            'What accomplishments would you be most proud of? Is your life today a good reflection of that perspective? Do you need to change your priorities?'
        ]
    ),
    
    new GateDescription(
        45,
        'The King or Queen',
        [
            'Gate 45 is the gate of the king or queen. This is the energy of natural leadership. People with Gate 45 will naturally be recognized as leaders with influence. This is not democratic leadership; this is easy and effortless leadership that has a regal feel to it.',
            'In the energy of this channel, it is Gate 45 that makes the proclamation of what we have or have not. The king or queen can be the great allocator or spender of the resources (though they will struggle without the help of Gate 21). Gate 45 is very tied to its tribe. Often, people with this energy will not make changes easily, especially if it means leaving their people.',
            'Gate 45 in its highest expression can be an energy of great influence. As a regal leader, this gate can inspire the tribe to work or rest, and it determines the work or sacrifices necessary to sustain resources.'
        ],
        [
            'I gather all the people necessary to support my manifestation in my life.',
            'I take leadership and honor my role as the king or queen of my creation.',
            'I assert my power, delegate, manage resources effectively, and act with benevolence.'
        ],
        [
            'Where in your life do you need to assume a leadership role? How do you feel as a leader? Is it okay for you to be in charge, honor your creation, and speak your truth?',
            'What do you need to do to attract the right people into your life to serve your manifestation and creation? Is your mindset aligned with being a team player, or a king or queen?',
            'The shadow side of a monarchy is that the king or queen can be controlling and punitive. Where do you need to let go of your creation and allow it to evolve?'
        ]
    ),
    
    new GateDescription(
        46,
        'Love of Body',
        [
            'Gate 46 is all about the physical embodiment of love. It understands that the body is a vehicle for the soul and is all about movement and living in the body. It is sensual, graceful, experiential, and grounded. People with this energy are deeply present to the body, and we see a lot of yoga teachers, dancers, and even portrait photographers with this energy.',
            'This gate is not about predicting or forecasting. It is not logical. It is the energy of being and experiencing in the body. It is also about giving the soul expression, and this energy can give way to deeply expressive art and movement. This entire channel is about being alive in a purely sensual way. It yearns to move, longs for expression, and holds dear to the responsibilities of commitment that give life meaning.',
            'If you have this energy, you may have a yearning for physical perfection or work as a healer.'
        ],
        [
            'Physical reality is an expression of my consciousness. I look to my reality to mirror my mindset and my beliefs back to me.',
            'I am clear, conscious, and awake. I can adjust my mindset to create any physical experience I choose.',
            'I take guided actions that are in alignment with my beliefs, and I celebrate this gift of being alive in a physical body!'
        ],
        [
            'What is your reality telling you? Are there messages you need to heed?',
            'What discourages you? Do you push, or do you allow? What do you need to do to allow rather than think through? Are your intentions and actions an accurate reflection of your true heart’s desires?'
        ]
    ),
    
    new GateDescription(
        47,
        'Realization',
        [
            'Gate 47 can be referred to as the mindset gate. When it operates with the expectation that the answer to how to do something will come, then it can move forward with confidence that its inspiration will somehow be answered by action, serendipity, and the magic of the Universe. But when Gate 47 gets stuck in trying to figure out how, it runs the risk of quitting before epiphany because the how is not answered. This traps Gate 47 in a mentally oppressive state, and it can come to believe that it doesn’t know how, and therefore what it is inspired to do is futile.',
            'The energy of Gate 47 demands leaps of faith, belief in the impossible, and a relaxation of the need to know. Gate 47 has to trust that the answer is coming, and it just needs to wait.',
            'The arrival of the epiphany depends on a person’s mindset. If you stay open and expect a solution, then the solution can show up easily. But if your mindset is closed, anxious, or pressured, it’s hard for the epiphany to break through the mental chatter. And when it does show up, if your attitude is closed, you might not trust the revealed solution. Mindset is always crucial.',
            'It is very important to address Gate 47, as it can be one of those energies that can profoundly impact you in a harsh way if you don’t understand how to work with it. Gate 47 is the gate of “epiphany,” the answer to the inspiration of Gate 64. However, unlike Gate 64, it works over time, and when it is uncoupled from Gate 64, it is simply the pressure to figure out how to make something happen.'
        ],
        [
            'I wait with delighted anticipation and marvel and the curious way the Universe manifests my desires.',
            'I keep my mindset joyful and positive, and I only focus on the end result.'
        ],
        [
            'What is the status of your mindset? Do you need to take care of your thought patterns?',
            'What things will you do while you are waiting for your manifestation? What will you do to keep your vibration high while you wait?'
        ]
    ),
    
    new GateDescription(
        48,
        'Depth',
        [
            'Gate 48 is a splenic fear-based gate. It is afraid that it will never know enough, that it will always be inadequate. The challenge with Gate 48 is to “just do it” even when you are scared. When you push through the moment, the fear dissipates, and Gate 48 can then begin to collect data over time to prove that it does indeed know enough. The fear of Gate 48 feels very real, even though others observing it may find it amusing. Usually people with Gate 48 are overprepared for everything.',
            'This is also the gate of taste, both visual and culinary. People with Gate 48 may have an intuitive understanding of beauty and design and long for things to be designed well. Or they may have sophisticated palates and desire rich culinary experiences. On the other side, they might be very picky eaters—especially if they are children.'
        ],
        [
            'I trust that the skills I need will be expressed through me when I am ready.',
            'I study. I learn. I know that my knowledge will be beautifully expressed when the time and the circumstances are correct.',
            'I trust Divine Order.',
            'I am perfectly prepared when the opportunity arises, and I honor myself for the depth of my knowledge.'
        ],
        [
            'What information do you need to deepen your knowledge base? What do you need to learn?',
            'Do you have the skills necessary to bring forth what you desire? If not, what do you need to master?'
        ]
    ),
    
    new GateDescription(
        49,
        'Principles',
        [
            'Gate 49 is the gatekeeper that allows the flow of energy to move toward a partnership or not. It determines the principles of intimacy held by a couple. Sometimes we refer to Gate 49 as the divorce gate. It is the energy that determines whether to continue to invest in the relationship if the principles of the relationship agreements are broken.',
            'This gate has a lot of black-and-white energy associated with it. For Gate 49, rules are rules. If you are in a relationship with a partner with Gate 49, you need to be very clear what the principles of the relationship agreement are. If these principles are violated in any way, Gate 49 will pack their bags and be done, and there will be no amount of renegotiating that can make them come back. The revolution of this gate is the decision to make a radical change in status if the principles dictate it.',
            'The forty-ninth gate is also the energy for other kinds of revolution. Revolution of any kind in Human Design is emotional. What that means is that revolution needs to be approached with deliberation and clarity. No “heat of the moment” impulses here … otherwise you jump right into chaos. Change should come about purely and deliberately.'
        ],
        [
            'Change is a necessary part of growth and evolution.',
            'I intentionally push into the new revolution of my life with courage and clarity.',
            'I trust that my steps toward change are crucial to creating what I intend for my life, and I am grateful for all that I have learned and all that I am about to receive.'
        ],
        [
            'Are your relationships and agreements working the way you intend? If not, what kinds of conversations do you need to have to create alignment?',
            'This is a week of radical transformation. What do you need to do to maintain a core or center in your world?',
            'What is the status of your connection to Source? Do you need to deepen your connection? If so, what will you do?',
            'What kinds of changes need to be made in your business or work agreements? What do you need to do to prepare for these changes?'
        ]
    ),
    
    new GateDescription(
        50,
        'Values',
        [
            'Values and laws are stored in Gate 50. Gate 50, like its counterpart, Gate 6, has the ability to penetrate other people’s auras. When you are with Gate 50, you will obey the rules and values of the tribe. Even if you are deeply individual, the energy of Gate 50 will force you energetically to be tribal. You will care and support even if it isn’t inherent in your design.',
            'Gate 50 is a love gate. This energy can be soft or rigid, but it will always be influential. The values of the tribe are transmitted with love. It may not always feel loving, but a smack on the behind in response to breaking a rule can be loving. And the intention is to bind the tribe together. Gate 50 will sacrifice its individual needs to take care of others. There is no mind here. It is pure instinct. People with Gate 50 often have a long history of taking care of others, including some who perhaps they should not be caring for.',
            'Caring with Gate 50 is instinctual and reflexive. The Sacral response will protect a person with Gate 50 from overnurturing. Gate 50 with an open Emotional Solar Plexus is easily manipulated with guilt. It is crucial that a person with Gate 50 rely on the Sacral to protect them from burning themselves out taking care of others.',
            'Gate 50 is also a fear gate. It is splenic, intuitive, and “in the now.” The dark expression of this energy can be a fear of failing one’s responsibilities. The deepest fear of Gate 50 is the fear of failing to take good care of its loved ones.'
        ],
        [
            'I establish the rules for my reality.',
            'I take care and nourish myself so that I may take care and nourish others.',
            'Everything I do for others I do for myself first in order to sustain my energy and power.',
            'I rule with self-love and then love freely.'
        ],
        [
            'What new rules do you need to play by? Do you need to create new rules in your relationships, your business, for your health, wealth, and welfare?',
            'Do you love yourself? Do you need to nurture yourself more? Do you have the strength and foundation to love freely? Do you feel safe in love?'
        ]
    ),
    
    new GateDescription(
        51,
        'Shock',
        [
            'Gate 51 is one of the most interesting gates in the Human Design system. It is very competitive or projects competitive energy and is the shock aspect of initiation. Many people with this gate will be shocking just for fun! Of course, this energy is radiated, so people with Gate 51 receive amplified shocking experiences. Gate 51 can have many shocking experiences that are initiating forces in their lives. Ra Uru Hu had Gate 51, and he was “shocked” into receiving the Human Design information. People with shock in their charts often have to have very intense, life-changing experiences before they can move into the love of Spirit. Many people with this gate have had neardeath experiences or some other kind of amazing story of shock and survival.',
            'As much as we resist shock, shock has a powerful role in starting things. Shock is designed to shake things up. In response to shock, we change. If we don’t change, we can become bitter. Certainly, you can expect to have new spiritual or mystical understanding when you have this energy.'
        ],
        [
            'I have the inner strength to deflect all outer shock.',
            'I am the manifestation of Spirit in form. I am courageous, steadfast, and open to the expansion of Spirit within me.',
            'My faith and courage inspire and initiate others.',
            'My vibration is high, and I lift others up with the truth of Spirit within me.',
            'I use all of my life experiences as catalysts to help me grow and evolve.'
        ],
        [
            'What lessons have you learned from shock? How have you transformed shock into strength? How has shock initiated you into the love of Spirit?'
        ]
    ),
    
    new GateDescription(
        52,
        'Stillness',
        [
            'The energy of this gate is the potential to sit in concentration, very still and very quietly, for long periods of time. Sometimes you might call this gate the couch potato gate.',
            'The irony of this gate is that without its harmonic, this is just sitting still without focus. Gate 52 makes for great wildlife photographers. You can sit in the blind for hours just watching and waiting, as long as you don’t get distracted.',
            'This is a highly creative energy, one that empowers you to concentrate on the goal, hold your gaze, wait in stillness until the right time, and then, and only then, take right actions.'
        ],
        [
            'The stillness of my concentration allows patterns and order to be revealed to me.',
            'My understanding of this order gives me the power to continue to create effectively.',
            'The stillness of my concentration is the source of my power.'
        ],
        [
            'What do you need to do to create stillness in your life?',
            'In the stillness, what questions do you have? What patterns are being revealed to you? How deeply do you feel the alignment of Divine Order?',
            'Define your power. Where are you powerful? Do you feel good being powerful? If not, why and what stops you from your power?',
            'Do you need to amplify your power? If so, how?'
        ]
    ),
    
    new GateDescription(
        53,
        'Starting Things',
        [
            'Gate 53 contains the energy for getting things started. When responding, this channel is always starting the right experience or bringing the energy of starting to others. Gate 53 is full of good intentions. Gate 53 is notorious for starting things and struggling to get them finished. It is normal for this gate to have all kinds of unfinished projects lying around the house.',
            'When Gate 53 is forced to finish something, it can be a long and arduous process. The energy for finishing just isn’t there. But when Gate 53 responds, it starts the right things and attracts to it the right people to finish the project. This gate makes a great initiator or project start-up manager. Never place Gate 53 in project management, though.',
            'Remember that the energy for getting started is far away from the Throat Center. That means there is still a lot of energy required for completion and expression. This is an initiating energy. A pulse for a new beginning.',
            'When the impulse to begin is correct and acted on correctly, then all of the energies, serendipities, and opportunities will magically unfold to bring your new beginning to its full expression in your life.'
        ],
        [
            'I wait and start things according to my strategy.',
            'I allow for the energy of new beginnings and trust that when I live my strategy, all the key pieces to complete my creative process will magically align.'
        ],
        [
            'Stay tuned this week to the energy of new beginnings and starting things. Allow the ideas, revelations, inspirations, and spurts of initiation energy to rev up your engines, but wait according to your strategy to jump in! Make a list of your new ideas or your renewed inspirations.'
        ]
    ),
    
    new GateDescription(
        54,
        'Drive',
        [
            'Gate 54 is the seat of ambition. It will work hard to fulfill its dreams and to get recognized. The irony is that there is not actually much energy here. As this gate works to provide and is based in Will energy, Gate 54 will work and work and work without a rest until it collapses.',
            'The projected aspect of Gate 54 can be quite bitter, but too busy working to do anything about it.',
            'The high side of Gate 54 can be quite beautiful. When recognized, it is the gate of enlightenment. The dreams of Gate 54, when supported and recognized, can go into the realm of unlimited possibility. Of course, even with these kinds of dreams, it must be recognized or else they are just dreams. With recognition, Gate 54 can do big things. Gate 54 can be an initiating force in any business. This is the chief dreamer of any operation.'
        ],
        [
            'I am clear. I am focused. I am ready to do whatever it takes to make my dreams come true.',
            'I know that my clarity married with my aligned actions are the perfect energies necessary to create miracles in my world.',
            'I am seen, heard, and recognized for what I have to offer, and the Universe perfectly conspires with me to make my dreams come true.'
        ],
        [
            'What actions do you need to take to show yourself and the Universe that you are ready to move toward your dreams?'
        ]
    ),
    
    new GateDescription(
        55,
        'Spirit',
        [
            'Gate 55 is the gate of abundance in Spirit. It is a beautiful, powerful, and potentially world-changing energy.',
            'In its highest expression, this is the recognition that the infinite abundance of life is available. Our consciousness and awareness of Spirit as the source of abundance in our lives can instantly shift us from a condition of lack to a condition of abundance. It’s just a matter of changing perspectives.',
            'But this is an energy that we often have to grow into. The energy for money and physical resources is deeply tied to the energy for working in the Sacral or willpower in the Will Center. We are deeply conditioned to believe that the only way to create abundance and resources in life is through sheer will and hard work. Gate 55 presents us with the spiritual question of how much we are willing to trust in the abundant nature of Spirit. Do we have to courage to let go and let God?',
            'For those who have this energy in their charts, this can be a lifelong journey. It takes courage to let go of traditional action and to trust in Spirit as your source of support. If you have this energy, you have to sometimes wait for the right timing or energy to take action. That also means that sometimes you have to act in a way that is seemingly counterintuitive and deal with the struggles in faith that can happen when you eschew the traditional path of working hard to make money.',
            'Ultimately, this energy teaches us that if we don’t have enough pie, we don’t have to struggle to figure out how to slice it. We can just bake more pies. The nature of life is limitlessly abundant. The consciousness of Spirit as Source is the most powerful awareness necessary to push the collective consciousness into creating the possibility for abundance for everyone on a global level.'
        ],
        [
            'I am aware of the abundance of Spirit within me, and I know that when I am focused on this abundance that all my desires are fulfilled and it is impossible to experience lack or need.',
            'I am completely supported and fulfilled by this awareness.',
            'By letting go and letting God, I allow abundance in all aspects of my life to manifest fully.',
            'Abundance is my birthright and my natural state.'
        ],
        [
            'What beliefs do you have about being fully supported and abundant? Do you need to align these beliefs with what you know is truth? What do you need to do to release worries and fears about abundance?',
            'What does being aware of the abundance of Spirit within feel like? What does it look like? How would being constantly aware of this fulfilling energy change your life? What do you need to do to be ready for this level of faith and trust?'
        ]
    ),
    
    new GateDescription(
        56,
        'The Storyteller',
        [
            'Gate 56 is one of the gifted-teaching gates. Gate 56 can be a great teacher who can effectively use metaphors to teach and share. Gate 56 can share the stories that help humanity understand its experience on the planet.',
            'While Gate 56 can be a gifted storyteller, it is crucial for people with this energy to remember that their stories are heard and remembered best when people ask for the story. A nonmotorized Throat or an undefined Throat with Gate 56 may often be a person who is constantly telling stories and can even push people away with too much storytelling. When Gate 56 is not waiting for invitations or recognition to share, they can bore people with their potentially captivating story and feel hurt that no one seems to listen.'
        ],
        [
            'I wait to share my ideas and stories with the right people who honor my inspiration and experience.',
            'My story is an important part of the human experience, and I honor my experience by waiting for the right circumstances.',
            'My words and my dreams are valuable.'
        ],
        [
            'Allow your imagination and playfulness to show you all the possibilities of how your dreams may manifest. Allow yourself to stay open to limitless possibilities, and practice telling yourself stories about how you dream of your life being.'
        ]
    ),
    
    new GateDescription(
        57,
        'Intuition',
        [
            'Gate 57 is the most intuitive gate in the Human Design system. In the traditional I Ching, the fifty-seventh hexagram is the gentle wind that parts the clouds so the sun can shine through. The penetrating intuition of Gate 57 allows the truth to be revealed. It is clear and in the now. Sometimes we call Gate 57 the gate of clarity.',
            'Ironically, in spite of its penetrating capacity for clarity, Gate 57 on its own can be a very uncertain and unclear energy. Most people question their intuition. It is not logical. The intuition of Gate 57 is in the now, and the now changes. What is truth in one moment may not be truth in another.',
            'People who have Gate 57 often struggle with trusting themselves and their intuition. Living your Human Design strategy can resolve this dilemma. The strategy can bypass the mental aspects of indecisiveness in Gate 57 and allow the person to enjoy the benefits of their intuition instead of wrestling with self-doubt.',
            'People with Gate 57 are endowed with deep psychic abilities. It helps to see what else is in the chart to help you identify just how psychic abilities show up.',
            'Gate 57 is a fear gate rooted in the Spleen. Gate 57 fears the future. This can also be some of the root cause of the lack of clarity in Gate 57. When Gate 57 sees a future that is potentially unclear or frightening, it can be paralyzed. As with all splenic fears, pushing through the fear makes the fear short-lived. But not pushing through can leave a person stuck in fear.'
        ],
        [
            'I trust myself.',
            'I trust my intuition.',
            'I trust the future.'
        ],
        [
            'What does your intuition feel like? How do you receive intuitive awareness? Make a list of previous events when you trusted your intuition and things worked out well.',
            'Are there any intuitive hunches you are receiving right now that need attention?',
            'What do you need to do to deepen your intuitive awareness?'
        ]
    ),
    
    new GateDescription(
        58,
        'Joy',
        [
            'Gate 58 is the energy for the joy of life. People with this gate always have a smile on their face if they live their strategy. These people intuitively understand joy and tend not to take things too seriously.',
            'However, if they are not living their strategy, people with Gate 58 can take a big beating in their joy of life. This is a dual system, after all. People with Gate 58 can be some of the most bitter people on the planet if they understand the potential for joy but are not able to experience it.',
            'The joy can be restored by living strategy and waiting for the right timing for correction. The ultimate beauty of this energy is that it stems from the energy of mastery and correction. Gate 58 can use all of the critical energy in the Logic Circuit to help people discover joy.'
        ],
        [
            'I am grateful for everything that I am, everything that I have, and everything that I have experienced.',
            'I allow joy to permeate every cell of my being, and I stand in awe of all my blessings.',
            'I relax and know that the shower of blessings that is my life is part of my divine heritage, and I relax knowing that an endless stream of good flows toward me.'
        ],
        [
            'Make a list of everything you are grateful for. Take a few minutes to really stay in that place of blissful appreciation every day.'
        ]
    ),
    
    new GateDescription(
        59,
        'Sexuality',
        [
            'Gate 59 is the gate of seduction. This is pure life force energy, the energy for sexuality or not.',
            'People with Gate 59 try to get to the bottom of intimacy, but the investigation may be theoretical. Gate 59 seeks to master intimacy with investigation. They may know a lot about intimacy, but none of their knowledge may be experiential.',
            'Conversely, Gate 59 may not think that much about intimacy at all, and may need others to bring it to their awareness. Many with Gate 59 feel that they need to have a solid understanding of their partner and relationship before they can commit themselves to intimacy. Because of this, Gate 59 prefers to be romantically involved with someone who is their best friend. True, deep intimacy for Gate 59 is most often found with their soul mate.',
            'Gate 59 also enjoys the game of seducing and being seduced by their partner. However, it may take some time for Gate 59 to commit themselves wholeheartedly to another.'
        ],
        [
            'I am present to love and wait to be called out into intimacy.',
            'I need space and freedom in my relationships. I need time to know that my love is real. It deepens my desire for connection and intimacy.',
            'I honor the friendship that is the foundation of my love. My love needs to be my best friend.',
            'I wait for clarity and enter into my relationships with great deliberation.',
            'Love is fun and seductive for me, and I enjoy the thrill of seducing my partner (and being seduced).'
        ],
        [
            'What avenues of impact would best serve you, your intentions, and your business?',
            'What is the next step in creating your intentions and your dreams?',
            'Where do you need to get to work to be ready for things to manifest?'
        ]
    ),
    
    new GateDescription(
        60,
        'Acceptance',
        [
            'Gate 60 is the energy for the old or established genetic energy. This is the place in the chart where “old” genetic energy meets up with “new” genetic information to create mutation. Gate 60 is conservative and seeks to hold on to what is known to work before it makes change. Gate 60 seeks to evolve, and people with this energy are often wanting to make change and experience personal growth that is careful and deliberate. This is not crazy change for change’s sake. This is deliberate and practical evolution that also accepts the limitations of change and makes the best of it.',
        ],
        [
            'I am an unlimited child of the Universe. If I receive an inspiration, I trust and know that the ability for me to bring that inspiration forth into form is mine.',
            'Inspiration and manifestation happen simultaneously. My only job is to breath, relax, trust, and know that all is in Divine Order.',
            'It is my job to pay attention to the messages the Universe is sends me and to simply follow my strategy. I don’t need to know how my inspirations will manifest.',
            'I release all resistance and trust that I am always in the right place, at the right time, doing the right thing with the right people.'
        ],
        [
            'Do you struggle when you don’t know how something is going to happen? How does this limit your ability to create?',
            'Are there circumstances or creations that you stop yourself from believing you can receive because you are stuck in the how?',
            'Where are you experiencing resistance in your life? What are you resisting? Why?',
            'What can you do to create more allowing and more ease in your life?'
        ]
    ),
    
    new GateDescription(
        61,
        'Mystery',
        [
            'Gate 61 is the initiating sequence to mutative thinking and has the task of transmitting its knowingness without the benefit of logic. Gate 61 knows, period. The end. And if you try to get Gate 61 to explain how it knows, you’re missing the point. Gate 61 reaches out to know the unknowable. It contains the energy for discovering or thinking about mystery and even the occult. But without an invitation to express what it knows, we just think it is a bit strange.',
            'The madness of Gate 61 is rooted in the desire to know why and the need to wait for clarity. The knowingness of this gate can often run ahead of itself, knowing what’s ahead without knowing the pieces in between. It can skip steps and move to a bigger awareness without acknowledging the places in between that could tie it all together. Gate 61 has to wait to know more, and if they are not honoring the invitation of life to simply enjoy thinking in the meantime, they can go crazy trying to understand more.',
            'Gate 61 has to wait for right timing to know whether what they know is of value. An important mantra for Gate 61 is: “Why ask why? Because it’s fun to think.” Remember that thinking is often done here simply for the sake of thinking.',
            'Of course, this is mutative thinking, so it’s bound to be different. The key to adaption in mutation is waiting for the right time, and, in this case, the right people, to invite Gate 61 to share what it knows. It is crucial for this gate to guard what it knows until someone asks for insight.'
        ],
        [
            'In the stillness I surrender to the great mystery of life and the Divine.',
            'I allow divine inspiration to wash over me, and I listen with great attention and appreciation.',
            'I trust that I receive the perfect inspiration and simply let the inspiration flow to me.',
            'I am grateful.'
        ],        
        [
            'Do you feel aligned with something bigger than yourself? What do you need to do deepen your connection with Source? Do you need to create a routine in your daily practice to stay centered and connected?'
        ]
    ),
    
    new GateDescription(
        62,
        'Details',
        [
            'This is the energy for details, the small details that keep the momentum of opinions flowing toward energy. Gate 62 asks, “What if we did it like this? What if we put this over here, and place all the files in this basket? Then would we be able to create an organizational pattern?” Even if they don’t look organized, they know where everything is.',
            'This is the gate of the computer programmer or the professional organizer. Gate 62 always has a practical experiment going. This is the energy for creating the structure and application of the experiment. Gate 62 determines the statistical tests to be done, what equipment to use, and how to log the data. It is the energy for articulating plans and ideas in an organized, logical manner. It connects the energy from the realm of possibility to the Throat Center and creates, through articulation, the possibility of manifestation.'
        ],
        [
            'I use my words carefully. My words generate form for my dreams and ideas.',
            'My thoughts are clear and organized, and I find and speak the truth with courage and consistency.',
            'I am organized and filled with practical solutions for others. I patiently wait for them to ask for my insight.'
        ],
        [
            'Time to revisit our vision and renew our commitment in words to our dreams. Write out your dream in words. It is the power of pure possibility expressed in words that creates things.',
        ]
    ),
    
    new GateDescription(
        63,
        'Doubt',
        [
            'Gate 63 contains the inspiration for logic. Gate 63 on its own is full of doubt and suspicion, followed by a demand for proof.',
            'This particular gate can have some interesting challenges built into it. Doubt and suspicions are energies. And like all energies in the Human Design chart, they flow, almost reflexively. People with Gate 63 will have a tendency to be doubtful and suspicious of everything, including their own insights and abilities.',
            'Although this is a valuable process for logic, it can be a difficult personal energy. The doubt and suspicion expressed by Gate 63 is intended to be pointed toward information, not toward yourself or others.',
            'When you see Gate 63 combined with Gate 48 and an open Head and Ajna, you have a potent combination for mental paralysis and deep interpersonal inadequacy. Remember, these are collective energies and not at all intended to be expressed toward the self. The purpose of these energies is to correct the expression of information in the world.',
            'The other aspect of this is recognizing that the doubt in the head is just a thought or idea and not necessarily true. It takes time to justify suspicion and doubt. You need proof. When you are out in the world freely expressing doubt and suspicion, is it usually met with resistance. Doubt is better left in your head until you have the data and you are asked to share.'
        ],
        [
            'I trust myself and the Divine.',
            'I trust that there is perfection in experimentation.',
            'I trust my insight and knowingness. I am discerning, but not doubtful.',
            'I know that all questions have answers. I trust in the elegant solution and know that the answer will be mine in time and all is well.'
        ],
        [
            'What experiences have you had that have caused you to doubt yourself?',
            'What experiences have you had that have shown you that your inner knowingness is correct? What are your gifts, your strengths, and your talents? Where have you demonstrated mastery, and what do you need to do to release self-doubt?',
            'Do you trust in Divine Order? Do you think everything has a purpose?',
            'What mistakes have you witnessed that ultimately created a path to perfection and mastery?',
            'What do you need to do to integrate mistakes as a crucial part of mastery?'
        ]
    ),
    
    new GateDescription(
        64,
        'Confusion',
        [
            'Gate 64 is the gate of the left eye and the right hemisphere of the brain. Information and inspiration comes in large chunks or “downloads.” An entire idea is formed seemingly out of thin air, without the sequential gifts of logic. One moment there is nothing, the next moment there is a big idea.',
            'The confusion and pressure of this gate manifests when you try to force a right-brained inspiration into a linear sequence. It’s difficult to implement the “how it’s going to happen” part of this kind of thinking if the timing is not right. Gate 64 has its own timing, and you cannot force a manifestation or even understanding until the timing is right.',
            'The real challenge of this gate is making peace with not knowing how things are going to happen. We live in a world that is deeply conditioned by logic and the left hemisphere. We are told that if we are inspired, it doesn’t “count” unless we can also figure out how it’s going to come into form. So, Gate 64 learns to either guess at the details or be quiet.',
            'There are strategies to help this way of thinking. Gate 64 thinks visually, and visual tools can help with learning and expression. A child with Gate 64 can learn to write logical and linear reports if given index cards to write their ideas on. The child can then visually organize the ideas until the flow feels correct.',
            'Gate 64 is often confusing to others. When Gate 64 speaks, it often has to speak “around and around” an idea until it hits upon some sort of sense. This can be confusing to those who are trying to follow the circles. Gate 64 is often busy trying to make big ideas happen. In children, these can be the kids who want to create “impossible” science experiments for the science fair and often need help breaking their big idea into smaller, more manageable tasks. Gate 64 can make peace with itself when it realizes that clarity comes in time in the form of epiphany. All Gate 64 has to do is wait, and the answer will come.',
            'As the representative energy of the right hemisphere, Gate 64 is also the gate of connection to super-consciousness. Greater understanding and more esoteric awarenesses can trigger inspiration in Gate 64. It’s not unusual to be inspired by a force that seems bigger than you and divinely sourced.'
        ],
        [
            'I pay attention to inspiration and know that when I wait with curious anticipation to see how my inspiration manifests, amazing things happen!',
            'I am delighted and curious to see what the Universe brings.'
        ],
        [
            'What are your big dreams?',
            'Do you trust that they will manifest?',
            'What strategies do you have to stay in joy while you wait for your manifestation?'
        ]
    )
];